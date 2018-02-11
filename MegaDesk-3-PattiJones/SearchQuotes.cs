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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Desk.Material));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string quote = "quotes.txt";

            //Clear what is inside the textbox
            //comboBox1.Rows.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(quote))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] quotes = sr.ReadLine().Split(',');
                        if (quotes.Contains(comboBox1.Text))
                        {
                            //comboBox1.Rows.Add(quotes[0], quotes[1], 
                                quotes[2], quotes[3], quotes[4], quotes[5], 
                                quotes[6], quotes[7]);
                        }
                        else
                        {
                            label1.Text = "No Matches";
                        }

                    }
                }
            }
            catch (FileNotFoundException)
            {
                label1.Text = "No desk quotes available";
            }
        }
    }
}
