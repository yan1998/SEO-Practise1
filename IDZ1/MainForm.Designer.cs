﻿namespace IDZ1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 67);
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
        private System.Windows.Forms.Button button1;
    }
}

