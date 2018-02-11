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

        }
		
		private void showQuotes(Desk.Material material)
		{
			string csvFile = "quotes.txt";
			try
			{
				string[] quotes = File.ReadAllLines(csvFile);

				foreach (string quote in quotes)
				{
					string[] row = quote.Split(',');

					if (row[4].Equals(material.ToString())) {

						dataGridView1.Rows.Add(row);
					}
				}
			}
			catch (FileNotFoundException e)
			{

			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			switch((Desk.Material) comboBox1.SelectedItem)
			{
				case Desk.Material.Laminate:
					showQuotes(Desk.Material.Laminate);
					break;
				case Desk.Material.Oak:
					showQuotes(Desk.Material.Oak);
					break;
				case Desk.Material.Veneer:
					showQuotes(Desk.Material.Veneer);
					break;
				case Desk.Material.Rosewood:
					showQuotes(Desk.Material.Rosewood);
					break;
				case Desk.Material.Pine:
					showQuotes(Desk.Material.Pine);
					break;
			}


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
