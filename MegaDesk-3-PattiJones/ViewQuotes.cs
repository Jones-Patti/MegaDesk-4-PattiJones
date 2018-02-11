using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_PattiJones
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
            string quote = "quotes.txt";
            try
            {
                using (StreamReader sr = new StreamReader(quote))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] quotes = sr.ReadLine().Split(',');
                        //displayQuotesTable.Rows.Add(quotes[0], quotes[1], 
                        //quotes[2], quotes[3], quotes[4], quotes[5], 
                        //quotes[6], quotes[7]);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                label1.Text = "No files with that name";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
