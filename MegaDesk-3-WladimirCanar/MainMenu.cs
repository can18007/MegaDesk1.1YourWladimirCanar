using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_WladimirCanar
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewQuoteForm = new ViewAllQuotes();
            addViewQuoteForm.Tag = this;
            addViewQuoteForm.Show(this);
            Hide();
        }

        private void BtnSearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuoteForm = new SearchQuotes();
            addSearchQuoteForm.Tag = this;
            addSearchQuoteForm.Show(this);
            Hide();

        }
    }
}
