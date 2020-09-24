using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Simple.Data;
using System.Dynamic;
using System.Globalization;

namespace TradingPlatform
{
    public partial class StockBuy : Form
    {
        public string MyUser { get; set; }
        public StockBuy()
        {
            InitializeComponent();
        }

        private void Getpricebtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // Build the URL for the stock the user selects.
            string url = "";
            if (Symboltxt.Text != "") url += Symboltxt.Text;
            if (url != "")
            {
                
                // Prepend the base URL.
                const string base_url =
                    //the url will download: symbol, Last trade price, Last trade date, Last trade time and change.
                    "http://download.finance.yahoo.com/d/quotes.csv?s=@&f=sl1d1t1c1";
                url = base_url.Replace("@", url);

                // Get the response.
                try
                {
                    // Get the web response.
                    string result = GetWebResponse(url);
                    Console.WriteLine(result.Replace("\\r\\n", "\r\n"));

                    // Pull out only the current prices of the stock.
                    string[] lines = result.Split(new char[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);
                    //Inserts the price into the price text box.
                    Pricetxt.Text = lines[0].Split(',')[1];
                }
                //error message if unsuccessful.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Read Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            this.Cursor = Cursors.Default;
        }

        //get the stock prices.
        // Return a number formatted as currency or
        // a blank string if the text isn't a number.

        private string FormatCurrency(string text)
        {
            decimal value;
            if (decimal.TryParse(text, out value)) return value.ToString("C3");
            return "";
        }

        // Get a web response.
        private string GetWebResponse(string url)
        {
            // Make a WebClient.
            WebClient web_client = new WebClient();

            // Get the indicated URL.
            Stream response = web_client.OpenRead(url);

            // Read the result.
            using (StreamReader stream_reader = new StreamReader(response))
            {
                // Get the results.
                string result = stream_reader.ReadToEnd();

                // Close the stream reader and its underlying stream.
                stream_reader.Close();

                // Return the result.
                return result;
            }
        }
        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
        private void Buybtn_Click(object sender, EventArgs e)
        {

            //allow users to add more stocks to bought securities           
            decimal stocks, price, cost;
            stocks = decimal.Parse(Stocktxt.Text);
            price = decimal.Parse(Pricetxt.Text);
            //price = decimal.Parse(Pricetxt.Text, NumberStyles.Currency);
            cost = Multiply(stocks, price);
            //use the username to check if he can pay the cost, then update the money he has.
            //Then add the record to the stock bought table.
            var db = Database.OpenNamedConnection("mainDb");
            var original = db.Customer.FindByUsername(Form1.usern);
            var SecurityBought = db.SecuritiesBought.FindByUsernameAndSecurity(Form1.usern, Symboltxt.Text);

            //  true if there are any records in the SecuritiesBought table with the current username and the security symbol.
            bool recordExists = db.securitiesBought.Exists(db.SecuritiesBought.Username == Form1.usern && db.SecuritiesBought.Security == Symboltxt.Text);
            //validation.
            if (!recordExists)

                {
                    //validates the users purchase and checks if they have enough money.
                    if (original.Available > cost)
                {
                    original.Available -= cost;
                    db.Customer.UpdateByUsername(original);
                    //add  record of the purchase to the SecuritiesBought table.
                    dynamic Trade = new ExpandoObject();
                    Trade.Username = Form1.usern;
                    Trade.Security = Symboltxt.Text;
                    Trade.Amount = stocks;
                    Trade.LatestPrice = price;
                    Trade.TotalCost = cost;
                    Trade.DateofLatestPurchase = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
                    db.SecuritiesBought.Insert(Trade);
                }
                //the user cant't buy stocks because he doesn't have enough money to finance the purchase.
                //error message.
                else
                {
                    MessageBox.Show("The user does not have enough money to finance the purchase", "Error", MessageBoxButtons.OK);
                }
            }
            //if the user arlready has stocks of the security.
            else if(recordExists)
            {
                if (original.Available >= cost)
                {
                    //the record already exists, as the user is buying more stocks,
                    //the amount of stocks, price and date need to be updated.
                    SecurityBought.Amount += stocks;
                    SecurityBought.TotalCost += cost;
                    SecurityBought.LatestPrice = price;
                    SecurityBought.DateofLatestPurchase = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
                    db.SecuritiesBought.Update(SecurityBought);
                    original.Available -= cost;
                    //updates the record by inserting the variable original.
                    db.Customer.UpdateByUsername(original);
                }
                //the user cant't buy stocks because he doesn't have enough money to finance the purchase.
                //error message.
                else
                {
                    MessageBox.Show("The user does not have enough money to finance the purchase", "Error", MessageBoxButtons.OK);
                }
            }

            
            
        }

        private void SellStockbtn_Click(object sender, EventArgs e)
        {
            decimal stocks, price, cost;
            //parses the values in the stocktxt, pricetxt text boxes into variables.
            //the program then calculates the total costs using the stocks and price variables.
            stocks = decimal.Parse(Stocktxt.Text);
            price = decimal.Parse(Pricetxt.Text, NumberStyles.Currency);
            cost = Multiply(stocks, price);
            var db = Database.OpenNamedConnection("mainDb");
            var SecurityBought = db.SecuritiesBought.FindByUsernameAndSecurity(Form1.usern, Symboltxt.Text);
            //searches for the current username in the SecuritiesBought table.
            var CustomerPL = db.Customer.FindByUsername(Form1.usern);

          //  true if there are any records in the Albums table with the current username and the security symbol.
            bool recordExists = db.securitiesBought.Exists(db.SecuritiesBought.Username == Form1.usern && db.SecuritiesBought.Security == Symboltxt.Text);
            //validation
            //if user has no stocks.
            if (!recordExists)
            {
                //error message.
                MessageBox.Show("The user does not have any stocks in the selected security", "Error", MessageBoxButtons.OK);
            }
            //if user has stocks
            else if(recordExists)
            {
                //if user has enough stocks for what they wish to sell.
                if (SecurityBought.Amount >= stocks)
                {
                    //updates the customer table.
                    decimal profitloss = Multiply(price, stocks) - Multiply(SecurityBought.LatestPrice, stocks);
                    CustomerPL.ProfitLoss += profitloss;
                    CustomerPL.Available += Multiply(price, stocks);
                    db.Customer.UpdateByUsername(CustomerPL);

                    //reduce costs and amount.
                    SecurityBought.Amount -= stocks;
                    SecurityBought.TotalCost -= cost;
                    //updates the SecuritiesBought table with the user's stock record.
                    db.SecuritiesBought.Update(SecurityBought);
                }
                else
                {
                    MessageBox.Show("The user does not have enough stocks", "Error", MessageBoxButtons.OK);
                }
            }

        }

        private void StockBuy_Load(object sender, EventArgs e)
        {

        }
    }
}
