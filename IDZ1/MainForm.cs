using BusinessLogic.Abstractions;
using Models.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDZ1
{
    public partial class MainForm : Form
    {
        private readonly IGoogleSearch _googleSearch;

        public MainForm(IGoogleSearch googleSearch)
        {
            _googleSearch = googleSearch;
            InitializeComponent();
        }

        private async void btn_searchCompetitors_Click(object sender, EventArgs e)
        {
            if (textBox_searchCompetitors.Text == string.Empty)
            {
                MessageBox.Show("Введите ключевое слово!");
            }
            else
            {
                var response = await _googleSearch.Search(textBox_searchCompetitors.Text);
            }
        }
    }
}
