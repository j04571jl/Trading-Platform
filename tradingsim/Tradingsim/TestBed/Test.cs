using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Simple.Data;

namespace TestBed
{

    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private static void Main(string[] args)
        {


            string csvData;

            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=AAPL+GOOG+MSFT&f=snbaopl1c");
            }

            //List<Price> prices = YahooFinance.Parse(csvData);

            //foreach (Price price in prices)
            //{
            //    //Unsure what this does.
            //    Console.WriteLine(string.Format("{0} ({1})  Bid:{2} Offer:{3} Last:{4} Open: {5} PreviousClose:{6} Change:{7}", price.Name, price.Symbol, price.Bid, price.Ask, price.Last, price.Open, price.PreviousClose, price.Change));
            //}
            //Console.Read();
        }

        //var repo = new TestBed.TestDb();
        //var work = repo.GetAllSecurityDataPoints();
        //Not sure of the of how to insert the list. (prices)
        // repo.Insert( prices string.Format("{0} ({1})  Bid:{2} Offer:{3} Last:{4} Open: {5} PreviousClose:{6} Change:{7}", price.Name, price.Symbol, price.Bid, price.Ask, price.Last, price.Open, price.PreviousClose, price.Change));

        /*WOULD THIS ENTER THE STOCK DATA INTO THE TABLE?----------------------------------------*/

        //    public void Insert(Price  prices)
        //{
        //    var db = Database.OpenNamedConnection("mainDb");
        //    db.SecurityPrices.Insert(prices);

        //}

        public static class YahooFinance
        {
            public static List<Price> Parse(string csvData)
            {
                var prices = new List<Price>();

                string[] rows = csvData.Replace("\r", "").Split('\n');

                foreach (string row in rows)
                {
                    if (string.IsNullOrEmpty(row)) continue;

                    string[] cols = row.Split(',');

                    Price p = new Price();
                    p.Symbol = cols[0];
                    p.Name = cols[1];
                    p.Bid = Convert.ToDecimal(cols[2]);
                    p.Ask = Convert.ToDecimal(cols[3]);
                    p.Open = Convert.ToDecimal(cols[4]);
                    p.PreviousClose = Convert.ToDecimal(cols[5]);
                    p.Last = Convert.ToDecimal(cols[6]);
                    p.Change = Convert.ToDecimal(cols[7]);

                    prices.Add(p);
                    //Method to add data to table. unconfirmed.
                    var repo = new TestBed.Test.TestDb();
                    var work = repo.GetAllSecurityDataPoints();

                    // im trying to get the peremeter to be "prices" but i can only use p, so i kept the insert function in the for loop.
                    repo.Insert(p);
                
                //Could the below code better than p?
                //    {
                //        Symbol = p.Symbol,
                //        Name = p.Name,
                //        Bid = p.Bid,
                //        Ask = p.Ask,
                //        Open = p.Open,
                //        PreviousClose = p.PreviousClose,
                //        Last = p.Last;
                //    Change = p.Change;
                //} )
                
                    
                }
                return prices;

                }
            }

            //what are some of these for?
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
                    var db = Database.OpenNamedConnection("mainDb");
                    db.SecurityPrices.Insert(sec);
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
                public string Name { get; set; }
                public decimal Bid { get; set; }
                public decimal Ask { get; set; }
                public decimal Open { get; set; }
                public decimal PreviousClose { get; set; }
                public decimal Last { get; set; }
                public decimal Change { get; set; }
            }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

