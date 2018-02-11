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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote, Desk desk)
        {
            InitializeComponent();
            dat.Text = deskQuote.QuoteDate.ToString();
            cName.Text = deskQuote.CustomerName;
            dWidth.Text = desk.Width.ToString();
            dDepth.Text = desk.Depth.ToString();
            nDrawers.Text = desk.Drawers.ToString();
            mat.Text = desk.DeskMaterial.ToString();
            del.Text = deskQuote.DeskQuoteDelivery.ToString();
            tPrice.Text = deskQuote.getTotalCost().ToString();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quote = "quotes.txt";
            if (!File.Exists(quote))
            {
                using (TextWriter sw = new StreamWriter(quote))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", 
                        dat.Text, cName.Text, dWidth.Text, dDepth.Text, nDrawers.Text, 
                        mat.Text, del.Text, tPrice.Text.Replace(",", ""));
                }
            }
            else
            {
                using (TextWriter sw = new StreamWriter(quote, append: true))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",
                        dat.Text, cName.Text, dWidth.Text, dDepth.Text, nDrawers.Text,
                        mat.Text, del.Text, tPrice.Text.Replace(",", ""));
                }
            }
        }
    }
}
