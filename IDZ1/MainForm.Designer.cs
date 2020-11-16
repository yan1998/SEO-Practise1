namespace IDZ1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_searchResults = new System.Windows.Forms.Panel();
            this.btn_searchCompetitors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_searchCompetitors = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_LowFrequencyKeywords = new System.Windows.Forms.RichTextBox();
            this.richTextBox_MediumFrequencyKeywords = new System.Windows.Forms.RichTextBox();
            this.richTextBox_HighFrequencyKeywords = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_lowFrequencyThreshold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_highFrequencyThreshold = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_KeywordsToGroupByFrequency = new System.Windows.Forms.RichTextBox();
            this.button_FrequencyGroup = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_StatisticTable = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_StaticticPeriod = new System.Windows.Forms.ComboBox();
            this.textBox_statisticKeyword = new System.Windows.Forms.TextBox();
            this.button_displayStatistic = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox_searchedPhrases = new System.Windows.Forms.RichTextBox();
            this.button_searchPhrases = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_searchPhrasesWord = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView_semanticKernel = new System.Windows.Forms.DataGridView();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView_textStatistic = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.button_analyzeText = new System.Windows.Forms.Button();
            this.richTextBox_textForAnalysis = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lowFrequencyThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_highFrequencyThreshold)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatisticTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_semanticKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_textStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 5;
            this.tabControl1.Size = new System.Drawing.Size(655, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel_searchResults);
            this.tabPage1.Controls.Add(this.btn_searchCompetitors);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_searchCompetitors);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Определение конкурентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_searchResults
            // 
            this.panel_searchResults.AutoScroll = true;
            this.panel_searchResults.Location = new System.Drawing.Point(111, 96);
            this.panel_searchResults.Name = "panel_searchResults";
            this.panel_searchResults.Size = new System.Drawing.Size(447, 212);
            this.panel_searchResults.TabIndex = 3;
            // 
            // btn_searchCompetitors
            // 
            this.btn_searchCompetitors.Location = new System.Drawing.Point(483, 42);
            this.btn_searchCompetitors.Name = "btn_searchCompetitors";
            this.btn_searchCompetitors.Size = new System.Drawing.Size(75, 23);
            this.btn_searchCompetitors.TabIndex = 2;
            this.btn_searchCompetitors.Text = "Поиск";
            this.btn_searchCompetitors.UseVisualStyleBackColor = true;
            this.btn_searchCompetitors.Click += new System.EventHandler(this.btn_searchCompetitors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ключевой запрос для поиска конкурентов";
            // 
            // textBox_searchCompetitors
            // 
            this.textBox_searchCompetitors.Location = new System.Drawing.Point(111, 42);
            this.textBox_searchCompetitors.Name = "textBox_searchCompetitors";
            this.textBox_searchCompetitors.Size = new System.Drawing.Size(313, 23);
            this.textBox_searchCompetitors.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.richTextBox_LowFrequencyKeywords);
            this.tabPage2.Controls.Add(this.richTextBox_MediumFrequencyKeywords);
            this.tabPage2.Controls.Add(this.richTextBox_HighFrequencyKeywords);
            this.tabPage2.Controls.Add(this.numericUpDown_lowFrequencyThreshold);
            this.tabPage2.Controls.Add(this.numericUpDown_highFrequencyThreshold);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.richTextBox_KeywordsToGroupByFrequency);
            this.tabPage2.Controls.Add(this.button_FrequencyGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Группировка по частотности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Низкочастотные ключевые слова:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Среднечастотные ключевые слова:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Высокочастотные ключевые слова:";
            // 
            // richTextBox_LowFrequencyKeywords
            // 
            this.richTextBox_LowFrequencyKeywords.Location = new System.Drawing.Point(398, 232);
            this.richTextBox_LowFrequencyKeywords.Name = "richTextBox_LowFrequencyKeywords";
            this.richTextBox_LowFrequencyKeywords.ReadOnly = true;
            this.richTextBox_LowFrequencyKeywords.Size = new System.Drawing.Size(233, 65);
            this.richTextBox_LowFrequencyKeywords.TabIndex = 6;
            this.richTextBox_LowFrequencyKeywords.Text = "";
            // 
            // richTextBox_MediumFrequencyKeywords
            // 
            this.richTextBox_MediumFrequencyKeywords.Location = new System.Drawing.Point(398, 132);
            this.richTextBox_MediumFrequencyKeywords.Name = "richTextBox_MediumFrequencyKeywords";
            this.richTextBox_MediumFrequencyKeywords.ReadOnly = true;
            this.richTextBox_MediumFrequencyKeywords.Size = new System.Drawing.Size(233, 65);
            this.richTextBox_MediumFrequencyKeywords.TabIndex = 6;
            this.richTextBox_MediumFrequencyKeywords.Text = "";
            // 
            // richTextBox_HighFrequencyKeywords
            // 
            this.richTextBox_HighFrequencyKeywords.Location = new System.Drawing.Point(398, 36);
            this.richTextBox_HighFrequencyKeywords.Name = "richTextBox_HighFrequencyKeywords";
            this.richTextBox_HighFrequencyKeywords.ReadOnly = true;
            this.richTextBox_HighFrequencyKeywords.Size = new System.Drawing.Size(233, 65);
            this.richTextBox_HighFrequencyKeywords.TabIndex = 6;
            this.richTextBox_HighFrequencyKeywords.Text = "";
            // 
            // numericUpDown_lowFrequencyThreshold
            // 
            this.numericUpDown_lowFrequencyThreshold.Location = new System.Drawing.Point(274, 146);
            this.numericUpDown_lowFrequencyThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_lowFrequencyThreshold.Name = "numericUpDown_lowFrequencyThreshold";
            this.numericUpDown_lowFrequencyThreshold.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown_lowFrequencyThreshold.TabIndex = 5;
            this.numericUpDown_lowFrequencyThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_highFrequencyThreshold
            // 
            this.numericUpDown_highFrequencyThreshold.Location = new System.Drawing.Point(274, 200);
            this.numericUpDown_highFrequencyThreshold.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_highFrequencyThreshold.Name = "numericUpDown_highFrequencyThreshold";
            this.numericUpDown_highFrequencyThreshold.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown_highFrequencyThreshold.TabIndex = 5;
            this.numericUpDown_highFrequencyThreshold.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "ВЧ запросы (после)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "НЧ запросы (до)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ключевые слова:";
            // 
            // richTextBox_KeywordsToGroupByFrequency
            // 
            this.richTextBox_KeywordsToGroupByFrequency.Location = new System.Drawing.Point(17, 36);
            this.richTextBox_KeywordsToGroupByFrequency.Name = "richTextBox_KeywordsToGroupByFrequency";
            this.richTextBox_KeywordsToGroupByFrequency.Size = new System.Drawing.Size(233, 269);
            this.richTextBox_KeywordsToGroupByFrequency.TabIndex = 1;
            this.richTextBox_KeywordsToGroupByFrequency.Text = "";
            // 
            // button_FrequencyGroup
            // 
            this.button_FrequencyGroup.Location = new System.Drawing.Point(274, 92);
            this.button_FrequencyGroup.Name = "button_FrequencyGroup";
            this.button_FrequencyGroup.Size = new System.Drawing.Size(100, 23);
            this.button_FrequencyGroup.TabIndex = 0;
            this.button_FrequencyGroup.Text = "Сгруппировать";
            this.button_FrequencyGroup.UseVisualStyleBackColor = true;
            this.button_FrequencyGroup.Click += new System.EventHandler(this.button_FrequencyGroup_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.dataGridView_StatisticTable);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.comboBox_StaticticPeriod);
            this.tabPage3.Controls.Add(this.textBox_statisticKeyword);
            this.tabPage3.Controls.Add(this.button_displayStatistic);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(647, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статистика по запросу";
            // 
            // dataGridView_StatisticTable
            // 
            this.dataGridView_StatisticTable.AllowUserToAddRows = false;
            this.dataGridView_StatisticTable.AllowUserToDeleteRows = false;
            this.dataGridView_StatisticTable.AllowUserToOrderColumns = true;
            this.dataGridView_StatisticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StatisticTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Value});
            this.dataGridView_StatisticTable.Location = new System.Drawing.Point(70, 74);
            this.dataGridView_StatisticTable.Name = "dataGridView_StatisticTable";
            this.dataGridView_StatisticTable.ReadOnly = true;
            this.dataGridView_StatisticTable.Size = new System.Drawing.Size(507, 233);
            this.dataGridView_StatisticTable.TabIndex = 3;
            this.dataGridView_StatisticTable.Text = "dataGridView2";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.Width = 230;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Value.Width = 230;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Выберите период:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Введите ключевой запрос:";
            // 
            // comboBox_StaticticPeriod
            // 
            this.comboBox_StaticticPeriod.FormattingEnabled = true;
            this.comboBox_StaticticPeriod.Items.AddRange(new object[] {
            "Past5Years",
            "PastYear",
            "Past3Months",
            "PastMonth",
            "PastWeek",
            "PastDay"});
            this.comboBox_StaticticPeriod.Location = new System.Drawing.Point(305, 32);
            this.comboBox_StaticticPeriod.Name = "comboBox_StaticticPeriod";
            this.comboBox_StaticticPeriod.Size = new System.Drawing.Size(121, 23);
            this.comboBox_StaticticPeriod.TabIndex = 2;
            // 
            // textBox_statisticKeyword
            // 
            this.textBox_statisticKeyword.Location = new System.Drawing.Point(72, 32);
            this.textBox_statisticKeyword.Name = "textBox_statisticKeyword";
            this.textBox_statisticKeyword.Size = new System.Drawing.Size(218, 23);
            this.textBox_statisticKeyword.TabIndex = 1;
            // 
            // button_displayStatistic
            // 
            this.button_displayStatistic.Location = new System.Drawing.Point(440, 32);
            this.button_displayStatistic.Name = "button_displayStatistic";
            this.button_displayStatistic.Size = new System.Drawing.Size(137, 23);
            this.button_displayStatistic.TabIndex = 0;
            this.button_displayStatistic.Text = "Показать статистику";
            this.button_displayStatistic.UseVisualStyleBackColor = true;
            this.button_displayStatistic.Click += new System.EventHandler(this.button_displayStatistic_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.richTextBox_searchedPhrases);
            this.tabPage4.Controls.Add(this.button_searchPhrases);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBox_searchPhrasesWord);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(647, 329);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Словосочетания";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Найденные словосочетания:";
            // 
            // richTextBox_searchedPhrases
            // 
            this.richTextBox_searchedPhrases.Location = new System.Drawing.Point(109, 99);
            this.richTextBox_searchedPhrases.Name = "richTextBox_searchedPhrases";
            this.richTextBox_searchedPhrases.ReadOnly = true;
            this.richTextBox_searchedPhrases.Size = new System.Drawing.Size(447, 199);
            this.richTextBox_searchedPhrases.TabIndex = 3;
            this.richTextBox_searchedPhrases.Text = "";
            // 
            // button_searchPhrases
            // 
            this.button_searchPhrases.Location = new System.Drawing.Point(481, 40);
            this.button_searchPhrases.Name = "button_searchPhrases";
            this.button_searchPhrases.Size = new System.Drawing.Size(75, 23);
            this.button_searchPhrases.TabIndex = 2;
            this.button_searchPhrases.Text = "Поиск";
            this.button_searchPhrases.UseVisualStyleBackColor = true;
            this.button_searchPhrases.Click += new System.EventHandler(this.button_searchPhrases_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Введите ключевое слово для поиска словосочетаний:";
            // 
            // textBox_searchPhrasesWord
            // 
            this.textBox_searchPhrasesWord.Location = new System.Drawing.Point(109, 40);
            this.textBox_searchPhrasesWord.Name = "textBox_searchPhrasesWord";
            this.textBox_searchPhrasesWord.Size = new System.Drawing.Size(313, 23);
            this.textBox_searchPhrasesWord.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.dataGridView_semanticKernel);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.dataGridView_textStatistic);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.button_analyzeText);
            this.tabPage5.Controls.Add(this.richTextBox_textForAnalysis);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(647, 329);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Семантический анализ";
            // 
            // dataGridView_semanticKernel
            // 
            this.dataGridView_semanticKernel.AllowUserToAddRows = false;
            this.dataGridView_semanticKernel.AllowUserToDeleteRows = false;
            this.dataGridView_semanticKernel.AllowUserToOrderColumns = true;
            this.dataGridView_semanticKernel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_semanticKernel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.count,
            this.frequency});
            this.dataGridView_semanticKernel.Location = new System.Drawing.Point(311, 183);
            this.dataGridView_semanticKernel.Name = "dataGridView_semanticKernel";
            this.dataGridView_semanticKernel.ReadOnly = true;
            this.dataGridView_semanticKernel.Size = new System.Drawing.Size(313, 138);
            this.dataGridView_semanticKernel.TabIndex = 4;
            this.dataGridView_semanticKernel.Text = "dataGridView1";
            // 
            // word
            // 
            this.word.HeaderText = "Слово";
            this.word.Name = "word";
            this.word.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Кол-во";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Частота";
            this.frequency.Name = "frequency";
            this.frequency.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Статистика текста:";
            // 
            // dataGridView_textStatistic
            // 
            this.dataGridView_textStatistic.AllowUserToAddRows = false;
            this.dataGridView_textStatistic.AllowUserToDeleteRows = false;
            this.dataGridView_textStatistic.AllowUserToOrderColumns = true;
            this.dataGridView_textStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_textStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.valueColumn});
            this.dataGridView_textStatistic.Location = new System.Drawing.Point(19, 183);
            this.dataGridView_textStatistic.Name = "dataGridView_textStatistic";
            this.dataGridView_textStatistic.ReadOnly = true;
            this.dataGridView_textStatistic.Size = new System.Drawing.Size(248, 138);
            this.dataGridView_textStatistic.TabIndex = 3;
            this.dataGridView_textStatistic.Text = "dataGridView1";
            // 
            // name
            // 
            this.name.FillWeight = 50F;
            this.name.HeaderText = "Показатель";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // valueColumn
            // 
            this.valueColumn.FillWeight = 30F;
            this.valueColumn.HeaderText = "Значение";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            this.valueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Текст для анализа:";
            // 
            // button_analyzeText
            // 
            this.button_analyzeText.Location = new System.Drawing.Point(276, 139);
            this.button_analyzeText.Name = "button_analyzeText";
            this.button_analyzeText.Size = new System.Drawing.Size(122, 23);
            this.button_analyzeText.TabIndex = 1;
            this.button_analyzeText.Text = "Проанализировать";
            this.button_analyzeText.UseVisualStyleBackColor = true;
            this.button_analyzeText.Click += new System.EventHandler(this.button_analyzeText_Click);
            // 
            // richTextBox_textForAnalysis
            // 
            this.richTextBox_textForAnalysis.Location = new System.Drawing.Point(19, 34);
            this.richTextBox_textForAnalysis.Name = "richTextBox_textForAnalysis";
            this.richTextBox_textForAnalysis.Size = new System.Drawing.Size(605, 98);
            this.richTextBox_textForAnalysis.TabIndex = 1;
            this.richTextBox_textForAnalysis.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Семантическое ядро:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 369);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lowFrequencyThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_highFrequencyThreshold)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatisticTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_semanticKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_textStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_searchCompetitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_searchCompetitors;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_searchResults;
        private System.Windows.Forms.Button button_FrequencyGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_KeywordsToGroupByFrequency;
        private System.Windows.Forms.NumericUpDown numericUpDown_highFrequencyThreshold;
        private System.Windows.Forms.NumericUpDown numericUpDown_lowFrequencyThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_LowFrequencyKeywords;
        private System.Windows.Forms.RichTextBox richTextBox_MediumFrequencyKeywords;
        private System.Windows.Forms.RichTextBox richTextBox_HighFrequencyKeywords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_displayStatistic;
        private System.Windows.Forms.ComboBox comboBox_StaticticPeriod;
        private System.Windows.Forms.TextBox textBox_statisticKeyword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_StatisticTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_searchPhrases;
        private System.Windows.Forms.TextBox textBox_searchPhrasesWord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox_searchedPhrases;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_analyzeText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox_textForAnalysis;
        private System.Windows.Forms.DataGridView dataGridView_textStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView_semanticKernel;
    }
}

