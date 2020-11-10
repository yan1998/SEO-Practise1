using BusinessLogic.Abstractions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IDZ1
{
    public partial class MainForm : Form
    {
        private readonly IGoogleSearchService _googleSearchService;
        private readonly IGoogleTrendsService _googleTrendsService;
        private readonly IBukvarixService _bukvarixService;

        public MainForm(IGoogleSearchService googleSearchService,
            IGoogleTrendsService googleTrendsService,
            IBukvarixService bukvarixService)
        {
            _googleSearchService = googleSearchService;
            _googleTrendsService = googleTrendsService;
            _bukvarixService = bukvarixService;
            InitializeComponent();
        }

        private async void btn_searchCompetitors_Click(object sender, EventArgs e)
        {
            var searchText = textBox_searchCompetitors.Text.Trim();
            if (searchText == string.Empty)
            {
                MessageBox.Show("Введите ключевое слово!");
            }
            else
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
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var test = await _bukvarixService.GetWordCombinations("Пирожок");
        }
    }
}
