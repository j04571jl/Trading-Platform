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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        //Displays the current users available funds upon loading of the form.
        private void Deposit_Load(object sender, EventArgs e)
        {
            var db = Database.OpenNamedConnection("mainDb");
            var user = db.Customer.FindByUsername(Form1.usern);
            Availabletxt.Text = Convert.ToString(user.Available);

        }
        //user selects the amount they wish to deposit.
        private void Depositbtn_Click(object sender, EventArgs e)
        {
            //set of coding that opens the customer table through the database and saves the current user's details to the variable user.
            var db = Database.OpenNamedConnection("mainDb");
            var user = db.Customer.FindByUsername(Form1.usern);
            //the value in the Deposit text box is parsed into the depositamount variable. 
            var depositamount = decimal.Parse(Deposittxt.Text);
            //depositamount is added to the user's Available attribute.
            user.Available += depositamount;
            //the current user's record is updated.
            db.Customer.UpdateByUsername(user);

            //message box which closes the form.
            DialogResult dialog = MessageBox.Show("the amount as been deposited into your account", "Complete", MessageBoxButtons.OK);
            if (dialog == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
