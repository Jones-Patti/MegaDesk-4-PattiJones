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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //populate combobox calling enums from the desk class. Ex combobox.dataSource;
            comboBox1.DataSource = Enum.GetValues(typeof(Desk.Material));
            comboBox2.DataSource = Enum.GetValues(typeof(DeskQuote.Delivery));
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //var mainMenu = (System.Windows.Forms.MainMenu)Tag;
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
   
        private void GetQuote_Click(object sender, EventArgs e)
        {
            //Collect information from user
            Desk desk = new Desk();
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.CustomerName = txtName.Text;
            desk.Width = (int)numericUpDown1.Value;
            desk.Depth = (int)numericUpDown2.Value;
            desk.Drawers = (int)numericUpDown3.Value;
            desk.DeskMaterial = (Desk.Material)comboBox1.SelectedValue;
            deskQuote.DeskQuoteDelivery = (DeskQuote.Delivery)comboBox2.SelectedValue;
            deskQuote.QuoteDate = DateTime.Now;
            deskQuote.Desk = desk;


            DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote, desk);
            displayQuoteForm.Show();
            this.Hide();
        }
    }
}
