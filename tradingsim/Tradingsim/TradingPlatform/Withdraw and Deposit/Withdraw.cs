using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Simple.Data;
using System.Net;

namespace TradingPlatform
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        //When the Withdraw form is loaded, the current users available balance in the customer table is loaded into the available textbox.
        public void Withdraw_Load(object sender, EventArgs e)
        {        
            //Opens the connection to the TradingSim database.
            var db = Database.OpenNamedConnection("mainDb");
            //Saves the current users details from the customer table into the variable user.
            var user = db.Customer.FindByUsername(Form1.usern);
            //copies the available balance from the customer table into the Available text box.
            Availabletxt.Text = Convert.ToString(user.Available);
        }
        //When the user clicks the withdraw button, the value in the Withdraw text box is removed from the users available balance.
        private void Withdrawbtn_Click(object sender, EventArgs e)
        {   
            var db = Database.OpenNamedConnection("mainDb");
            var user = db.Customer.FindByUsername(Form1.usern);
            //value typed, by the user, into the Withdraw text box is parsed into the withdrawalamount variable.
            var withdrawalamount = decimal.Parse(Withdrawtxt.Text);
            //Validation; checks if the user has enough money to withdraw the amount selected.
            if (user.Available >= withdrawalamount)
            {
                //the withdrawal amount is removed from the variable's attribute Available.
                user.Available -= withdrawalamount;
                //The Customer table is updated.
                db.Customer.UpdateByUsername(user);
                //message box which closes the Withdrawal form.
                DialogResult dialog = MessageBox.Show("the amount Has been withdrawn from your account", "Complete", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            //if the user doesn't have enough money, a message box appears.
            else
            {
                MessageBox.Show("The user does not have enough money to withdraw this amount", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
