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

        public StockView()
        {
            InitializeComponent();
        }

        //Shows the chart of a selected stock in the timescale of three months.
        private void threemonthbtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://chart.finance.yahoo.com/c/3m/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        //Shows the chart of a selected stock in the timescale of one year.
        private void oneyearbtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://chart.finance.yahoo.com/c/1y/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Shows the chart of a selected stock in the timescale of one day.
        private void onedaybtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://chart.finance.yahoo.com/c/my/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        //Shows the chart of a selected stock in the timescale of five years.
        private void fiveyearbtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://chart.finance.yahoo.com/c/5y/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Shows the chart of a selected stock in the timescale of six months.
        private void sixmonthbtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://chart.finance.yahoo.com/c/6m/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Shows the chart of a selected stock in the timescale of .
        private void maxbtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    
                    ChartImg.Load("http://chart.finance.yahoo.com/c/my/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Shows the chart of a selected stock in the timescale of five years.
        private void twoyearbtn_Click(object sender, EventArgs e)
        {
            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {

                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://chart.finance.yahoo.com/c/2y/" + symbols + "?" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Shows the chart of a selected stock in the timescale of five years.
        private void fivedaybtn_Click(object sender, EventArgs e)
        {

            // Return the stock quote data in XML format.
            string symbols = txtSymbol.Text.Trim();
            if (symbols == null)
                return;
            else
            {
                try
                {
                    // Display stock charts.       
                    // Use a random number to defeat cache. 
                    Random random = new Random();
                    ChartImg.Load("http://ichart.finance.yahoo.com/w?s=" + symbols + "&" + random.Next());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void StockView_Load(object sender, EventArgs e)
        {

        }
    }
    }
