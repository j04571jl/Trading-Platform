using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TradingPlatform
{
   
    public partial class Form1 : Form
    {
        ILoginManager loginMan { get; set; }
      
        public Form1()
        {
            
            //where 'CsvLoginManager' can be swapped out for 'AlwaysAllowToLoginManager'.
            //using the string "loginMan" allows the programmer to only need to change the class the string equates to,
            // rather than changing sections of coding. 
            loginMan = new CsvLoginManager();
            InitializeComponent();
        }
        public static string usern;
        public string  Username
        {
            get { return UsernameEdit.Text; }
        }
        //Button cancels the progression of the user's login.
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel");
        }
        // Public string is delcared in order to hold the values of the Username edit box.
        // The public string is later used for loading the current user's details.
            public string MyValue
            {
                get { return UsernameEdit.Text; }
            }
        //public string Username { get; set; }
/////////currently: trying to get the username logged in, to go into the search textbox on main menu, in order to the load account info of user.
        public void button2_Click(object sender, EventArgs e)
        {
            //the if statement validates the username and password by passing the Username and password text as parameters to the interface located on "ILohinManager"
            if (loginMan.Login(this.UsernameEdit.Text, this.PasswordEdit.Text))
            {
                //saves the user's username into a string variable
                usern = UsernameEdit.Text;
                //allows the username to be assigned in the stockbuy form.
                //get messageboxbutton.ok to when clicked open the mainpage.
                DialogResult dresult = MessageBox.Show("Logged in", "Confirmation" , MessageBoxButtons.OK);
                if (dresult == DialogResult.OK)
                {
                    //opens the main form
                    // hides the login form
                    this.Hide();
                    MainPage m1 = new MainPage();
                    m1.Show();
                    // show main form
                  
                }
            }
            //If the username and password are incorrect, the message box will appear.
            else
            {
                MessageBox.Show("NO ENTRY!");
            }

        }
    }



}
