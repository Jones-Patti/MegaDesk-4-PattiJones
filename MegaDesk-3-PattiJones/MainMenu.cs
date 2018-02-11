using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_PattiJones
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ViewQuotes addNewQuoteForm = new ViewQuotes(this);
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes addNewQuoteForm = new SearchQuotes();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
