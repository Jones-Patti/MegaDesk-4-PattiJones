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
		private Form MainMenuForm;

        public ViewQuotes(Form mainMenu)
        {
            InitializeComponent();

			MainMenuForm = mainMenu;

			showQuotes();
        }

		private void showQuotes()
		{
			string csvFile = "quotes.txt";
			try
			{
				string[] quotes = File.ReadAllLines(csvFile);

				foreach (string quote in quotes)
				{
					string[] row = quote.Split(',');
					dataGridView1.Rows.Add(row);
				}
			}
			catch (FileNotFoundException e)
			{

			}
		}

		private void ViewQuotes_FormClosed(object sender, FormClosedEventArgs e)
		{
			MainMenuForm.Show();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
