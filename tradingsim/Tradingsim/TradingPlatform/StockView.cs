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
    public partial class StockView : Form
    {   
        //stock symbols seperated by space or comma
        protected string q_symbol = "";
        public StockView()
        {
            InitializeComponent();
            if (q_symbol == "")
                q_symbol = "YHOO";
            else
                q_symbol = txtSymbol.Text;
            txtSymbol.Text = q_symbol;
        }

        private void StockView_Load(object sender, EventArgs e)
        {

        }

        private void GetQuotesBtn_Click(object sender, EventArgs e)
        {
            q_symbol = txtSymbol.Text;
            if (q_symbol.Trim() != "")
            {
                try
                {
                    // Return the stock quote data in XML format. [GetQuote(q_symbol.Trim());]
                    String arg = q_symbol.Trim();
                    if (arg == null)
                        return;


                    // Display stock charts.
                    String[] symbols = q_symbol.Replace(",", " ").Split(' ');
                    // Loop through each stock
                    for (int i = 0; i < symbols.Length; ++i)
                    {
                        if (symbols[i].Trim() == "")
                            continue;
                        // If index = -1, the stock symbol is valid.
                        // Use a random number to defeat cache.
                        Random random = new Random();
                        //possibly edit this to display a varierty of forms of charts.
                        ChartImg.Load("http://ichart.finance.yahoo.com/b?s=" + symbols[i].Trim().ToUpper() + "&" + random.Next());
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show(ex.Message);
                }
            }
            }
    }
}
