using BusinessLogic.Abstractions;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDZ1
{
    public partial class MainForm : Form
    {
        private readonly IGoogleSearchService _googleSearchService;
        private readonly IGoogleTrendsService _googleTrendsService;
        private readonly IBukvarixService _bukvarixService;
        private readonly IAdvegoService _advegoService;

        public MainForm(IGoogleSearchService googleSearchService,
            IGoogleTrendsService googleTrendsService,
            IBukvarixService bukvarixService,
            IAdvegoService advegoService)
        {
            _googleSearchService = googleSearchService;
            _googleTrendsService = googleTrendsService;
            _bukvarixService = bukvarixService;
            _advegoService = advegoService;
            InitializeComponent();
        }

        private async void btn_searchCompetitors_Click(object sender, EventArgs e)
        {
            var searchText = textBox_searchCompetitors.Text.Trim();
            if (searchText == string.Empty)
            {
                MessageBox.Show("Введите ключевое слово!");
                return;
            }

            try
            {
                this.panel_searchResults.Controls.Clear();
                var response = await _googleSearchService.Search(searchText);
                if (response.Items == null)
                {
                    MessageBox.Show("Конкуренты не найдены!");
                }
                else
                {
                    for (int i = 0; i < response.Items.Count; i++)
                    {
                        var labelTitle = new Label
                        {
                            Location = new Point(0, i * 120),
                            Name = $"label_SearchResponseTitle{i}",
                            Text = response.Items[i].Title,
                            Size = new Size(this.panel_searchResults.Width - 10, 20)
                        };
                        var linkLabel = new LinkLabel
                        {
                            Location = new Point(0, (i * 120) + 20),
                            Name = $"label_SearchResponseLink{i}",
                            Text = response.Items[i].Link,
                            Size = new Size(this.panel_searchResults.Width - 10, 20),
                        };
                        linkLabel.LinkClicked += linkLabel_LinkClicked;
                        var richTextBoxSnippet = new RichTextBox
                        {
                            Location = new Point(0, (i * 120) + 40),
                            Name = $"label_SearchResponseSnippet{i}",
                            Text = response.Items[i].Snippet,
                            Size = new Size(this.panel_searchResults.Width - 10, 60),
                            ReadOnly = true
                        };
                        var labelUnderScore = new Label
                        {
                            Location = new Point(0, (i * 120) + 100),
                            Name = $"label_SearchResponseTitle{i}",
                            Text = "________________________________________________________________________________",
                            Size = new Size(this.panel_searchResults.Width - 10, 20)
                        };
                        this.panel_searchResults.Controls.Add(labelTitle);
                        this.panel_searchResults.Controls.Add(linkLabel);
                        this.panel_searchResults.Controls.Add(richTextBoxSnippet);
                        this.panel_searchResults.Controls.Add(labelUnderScore);
                    }
                }
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }

        private async void button_FrequencyGroup_Click(object sender, EventArgs e)
        {
            if (richTextBox_KeywordsToGroupByFrequency.Lines.Length == 0)
            {
                MessageBox.Show("Введите ключевые слова");
                return;
            }

            try
            {
                var highFrequencyThreshold = (int)numericUpDown_highFrequencyThreshold.Value;
                var lowFrequencyThreshold = (int)numericUpDown_lowFrequencyThreshold.Value;
                var highFrequencyKeywordsList = new List<string>();
                var mediumFrequencyKeywordsList = new List<string>();
                var lowFrequencyKeywordsList = new List<string>();

                var searchKeywords = richTextBox_KeywordsToGroupByFrequency.Lines
                    .Where(x => x.Trim() != string.Empty)
                    .Select(x => x.ToLower())
                    .Distinct();

                foreach (var keyword in searchKeywords)
                {
                    var response = await _googleTrendsService.GetTrendsForPeriod(keyword, GoogleTrendsPeriod.PastMonth);
                    var averageFrequency = response.Default.TimelineData.Sum(x => x.Value.Single());
                    
                    if (averageFrequency >= highFrequencyThreshold)
                        highFrequencyKeywordsList.Add($"{keyword} - {averageFrequency}");
                    else if (averageFrequency < lowFrequencyThreshold)
                        lowFrequencyKeywordsList.Add($"{keyword} - {averageFrequency}");
                    else
                        mediumFrequencyKeywordsList.Add($"{keyword} - {averageFrequency}");
                }

                richTextBox_HighFrequencyKeywords.Lines = highFrequencyKeywordsList.ToArray();
                richTextBox_MediumFrequencyKeywords.Lines = mediumFrequencyKeywordsList.ToArray();
                richTextBox_LowFrequencyKeywords.Lines = lowFrequencyKeywordsList.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void button_displayStatistic_Click(object sender, EventArgs e)
        {
            if (textBox_statisticKeyword.Text.Trim() == "")
            {
                MessageBox.Show("Введите ключевое слово!");
                return;
            }

            if (comboBox_StaticticPeriod.Text == "")
            {
                MessageBox.Show("Выберите период!");
                return;
            }

            try
            {
                var period = (GoogleTrendsPeriod)Enum.Parse(typeof(GoogleTrendsPeriod), comboBox_StaticticPeriod.Text);
                var response = await _googleTrendsService.GetTrendsForPeriod(textBox_statisticKeyword.Text, period);
                if (response.Default.TimelineData.Count == 0)
                    MessageBox.Show("Информация о данном запросе отсутствует!");
                dataGridView_StatisticTable.Rows.Clear();
                foreach (var item in response.Default.TimelineData)
                {
                    dataGridView_StatisticTable.Rows.Add(item.FormattedTime, item.Value.Single());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void button_searchPhrases_Click(object sender, EventArgs e)
        {
            if (textBox_searchPhrasesWord.Text.Trim() == "")
            {
                MessageBox.Show("Введите ключевое слово!");
                return;
            }

            try
            {
                richTextBox_searchedPhrases.Text = string.Empty;
                var phrases = await _bukvarixService.GetWordCombinations(textBox_searchPhrasesWord.Text.Trim());
                foreach (var phrase in phrases.Data.OrderByDescending(x => int.Parse(x[3])))
                {
                    richTextBox_searchedPhrases.Text += $"{phrase[0]}\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void button_analyzeText_Click(object sender, EventArgs e)
        {
            if (richTextBox_textForAnalysis.Text.Trim() == "")
            {
                MessageBox.Show("Введите текст для анализа!");
                return;
            }

            try
            {
                var response = await _advegoService.AnalyzeText("«Приключения Алисы в Стране чудес» (англ. Alice’s Adventures in Wonderland), часто используется сокращённый вариант «Алиса в Стране чудес» (англ. Alice in Wonderland) — сказка, написанная английским математиком, поэтом и прозаиком Чарльзом Лютвиджем Доджсоном под псевдонимом Льюис Кэрролл и изданная в 1865 году. В ней рассказывается о девочке по имени Алиса, которая попадает сквозь кроличью нору в воображаемый мир, населённый странными антропоморфными существами. Сказка пользуется устойчивой популярностью как у детей, так и взрослых. Книга считается одним из лучших образцов литературы в жанре абсурда; в ней используются многочисленные математические, лингвистические и философские шутки и аллюзии. Ход повествования и его структура оказали сильное влияние на искусство, особенно на жанр фэнтези. «Алиса в Зазеркалье» является сюжетным продолжением произведения. «Приключения Алисы в Стране чудес» является литературной обработкой рукописной[1] книги «Приключения Алисы под землёй»[2].");

                dataGridView_textStatistic.Rows.Clear();
                dataGridView_semanticKernel.Rows.Clear();

                foreach (var item in response.TextStatistic)
                {
                    dataGridView_textStatistic.Rows.Add(item.Key, item.Value);
                }

                foreach (var item in response.SemanticKernel)
                {
                    dataGridView_semanticKernel.Rows.Add(item.Key, item.Value.Count, item.Value.Frequency);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
