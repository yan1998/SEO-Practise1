using BusinessLogic.Abstractions;
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

        private void btn_searchCompetitors_Click(object sender, EventArgs e)
        {
            _googleSearch.Test();
        }
    }
}
