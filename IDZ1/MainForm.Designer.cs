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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lowFrequencyThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_highFrequencyThreshold)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
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
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(647, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.Button button1;
    }
}

