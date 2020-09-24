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
    public partial class MainPage : Form
    {
        public string CurrentUser { get; set; }


        public MainPage()
        {
           
            InitializeComponent();
        }
        //button that logs out the current user and returns the current user to the login form.
        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            // hide main form
            // show login form
            this.Hide();
          
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }



        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //get messageboxbutton.ok to when clicked open the mainpage.
            DialogResult dresult2 = MessageBox.Show("Do you wish to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dresult2 == DialogResult.Yes)
            {
                //opens the main form
                // hides the login form
                this.Hide();

                // show main form
                Form1 f2 = new Form1();
                f2.ShowDialog();
            }
        }


        //On button click it opens the Stock View form where the user can view graphs of stocks.
        private void Button1_Click(object sender, EventArgs e)
        {
           // hides the MainPage. 
           //opens the StockView.
            
            StockView sv1 = new StockView();
            sv1.ShowDialog();
        }
        //On button click the void opens the Stock Buy form where users can view current quote prices of a stock 
        //and purchase an amount of stocks based on the price shown.
        private void OpenStockBuybtn_Click(object sender, EventArgs e)
        {   
            // hide the Main Page form.
            // show Stock Buy form
            StockBuy sb2 = new StockBuy();
            sb2.ShowDialog();
        }
        //------------------------------------------------------------------------------------------


        //updates stock data.
        private void UpdateFXbtn_Click(object sender, EventArgs e)
                {
            //coding that allows the programmer to select securities.
            var stocksToAdd = new[] { "AAPL", "GOOG", "MSFT", "INTC", "SBUX" };
                    var csv = GetSymbolPriceCsv(stocksToAdd);
                    List<Price> result = YahooFinance.ParseList(csv);
        
                    var repo = new TestDb();

                    foreach (var symbol in result)
                    {
                        
                        repo.Insert(symbol);
                    }

            this.securityPricesTableAdapter.Fill(this.tradingPlatformDBDataSet.SecurityPrices);
        }

         public static string GetSymbolPriceCsv(string[] symbols)
    {
        string csvData;
        string symbolsString = string.Join("+", symbols);

        using (WebClient web = new WebClient())
        {
            csvData = web.DownloadString($"http://finance.yahoo.com/d/quotes.csv?s={symbolsString}&f=snbaopl1c");
        }

        return csvData;

    }
        public static class YahooFinance
        {   //stock data is formatted to allow the program to read the values. Then returned to "GetValues"
            //public static Price Parse(string csvData)

            public static List<Price> ParseList(string csvData)
            {
                var rows = csvData.Replace("\r", "").Split('\n');
                //the last empty row is ignored.
                return rows.Take(rows.Count() - 1).Select(GetValues).ToList();

            }

            public static Price GetValues(string rows)
            {
                Price tempp = new Price();
                //validation
                try
                {
                    var cols = rows.Split(',');
                    //formats the stock data into the attributes.
                    Price p = new Price();
                    p.Symbol = cols[0];
                    p.Security = cols[1];
                    p.Bid = Convert.ToDecimal(cols[2]);
                    p.Ask = Convert.ToDecimal(cols[3]);
                    p.Open = Convert.ToDecimal(cols[4]);
                    p.PreviousClose = Convert.ToDecimal(cols[5]);
                    p.Last = Convert.ToDecimal(cols[6]);
                    p.Change = ((p.PreviousClose - p.Ask) / p.PreviousClose) * 100;
                    tempp = p;
                }
                //error message if data cant be parsed correctly.
                catch
                {
                    MessageBox.Show("The security is not valid", "Error", MessageBoxButtons.OK);
                }

                return tempp;
                
                
            }
        }

        private void DeleteSecbtn_Click(object sender, EventArgs e)
        {
            var db = Database.OpenNamedConnection("mainDb");
            db.SecurityPrices.DeleteAll();
            this.securityPricesTableAdapter.Fill(this.tradingPlatformDBDataSet.SecurityPrices);
        }

        public void MainPage_Load(object sender, EventArgs e)
        {


            // loads the current users username into the username textbox
            usernameedit.Text = Form1.usern;

            var db = Database.OpenNamedConnection("mainDb");
            var user = db.Customer.FindByUsername(Form1.usern);
            Availabletxt.Text = Convert.ToString(user.Available);
            ProfitLosstxt.Text = Convert.ToString(user.ProfitLoss);
            tradingPlatformDBDataSet.EnforceConstraints = false;
            //  This line of code loads data into the 'tradingPlatformDBDataSet.SecurityPrices' table. You can move, or remove it, as needed.
            this.securityPricesTableAdapter.Fill(this.tradingPlatformDBDataSet.SecurityPrices);


        }
        //updates the users the available and profitloss textboxes, if theres any data changes in the customer table.
        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            var db = Database.OpenNamedConnection("mainDb");
            var user = db.Customer.FindByUsername(Form1.usern);
            Availabletxt.Text = Convert.ToString(user.Available);
            ProfitLosstxt.Text = Convert.ToString(user.ProfitLoss);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit d1 = new Deposit();
            d1.ShowDialog();
        }

        private void WithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw w1 = new Withdraw();
            w1.ShowDialog();
        }

        private void securityPricesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tradingPlatformDBDataSetBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tradingPlatformDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Mystockbtn_Click(object sender, EventArgs e)
        {
            UserDWform US = new UserDWform();
            US.ShowDialog();
        }
    }
    public class TestDb
        {
            public List<Price> GetAllSecurityDataPoints()
            {
                var db = Database.OpenNamedConnection("mainDb");
                var work = db.SecurityPrices.All();
                return work;
            }

            public void Insert(Price sec)
            {
                try
                {
                    var db = Database.OpenNamedConnection("mainDb");
                    db.SecurityPrices.Insert(sec);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            public List<Price> GetAllSecurityDataPoints(string security)
            {
                var db = Database.OpenNamedConnection("mainDb");
                var work = db.SecurityPrices.All();
                return work;
            }

        }

   

    public class Price
        {
            public string Symbol { get; set; }
            public string Security { get; set; }
            public decimal Bid { get; set; }
            public decimal Ask { get; set; }
            public decimal Open { get; set; }
            public decimal PreviousClose { get; set; }
            public decimal Last { get; set; }
            public decimal Change { get; set; }
        }
}

    
    
