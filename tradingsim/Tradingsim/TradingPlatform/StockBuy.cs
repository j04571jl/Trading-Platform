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

namespace TradingPlatform
{
    public partial class StockBuy : Form
    {
        public StockBuy()
        {
            InitializeComponent();
        }

        private void getpricebtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // Build the URL.
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

                    // Pull out the current prices.
                    string[] lines = result.Split(new char[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);
                    Pricetxt.Text = FormatCurrency(lines[0].Split(',')[1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Read Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            this.Cursor = Cursors.Default;
        }

        //get the stock prices
        // Return a number formatted as currency or
        // a blank string if the text isn't a number.
        //NOTE: try to change currency to $
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
    }
}
