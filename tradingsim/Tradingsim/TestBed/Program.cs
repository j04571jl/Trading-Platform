using Simple.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBed
{
    class Program
    {
        
            
        static void Main(string[] args)
        {
            Application.Run(new Form1());
            //successfully calls a record from a table and can update a field of selection.
            //var db = Database.OpenNamedConnection("mainDb");
            //var original = db.Customer.FindByUsername("jlloyd");
            //original.Available = 300;
            //db.Customer.UpdateByUsername(original);

            //var stocksToAdd = new[] { "AAPL", "GOOG", "MSFT" };
            //var csv = GetSymbolPriceCsv(stocksToAdd);
            //List<Price> result = YahooFinance.ParseList(csv);
            ////List<Price> result = stocksToAdd.Select(x => YahooFinance.Parse(GetSymbolPriceCsv(x))).ToList();

            ////var result = YahooFinance.Parse(csvData);
            ////Method to add data to table. unconfirmed.
            //var repo = new TestDb();
            ////var work = repo.GetAllSecurityDataPoints();

            //foreach (var symbol in result)
            //{
            //    repo.Insert(symbol);
            //}

        }
        
        //public static string GetSymbolPriceCsv(string symbol)
        //{
        //    string csvData;

        //    using (WebClient web = new WebClient())
        //    {
        //        csvData = web.DownloadString($"http://finance.yahoo.com/d/quotes.csv?s={symbol}&f=snbaopl1c");
        //    }

        //    return csvData;
        //}
        
        
        //public static string GetSymbolPriceCsv(string[] symbols)
        //{
        //    string csvData;
        //    string symbolsString = string.Join("+", symbols);

        //    using (WebClient web = new WebClient())
        //    {
        //        csvData = web.DownloadString($"http://finance.yahoo.com/d/quotes.csv?s={symbolsString}&f=snbaopl1c");
        //    }

        //    return csvData;

        //}
    }
    


}

public static class YahooFinance
{   //stock data is formatted to allow the program to read the values. Then returned to "GetValues"
    //public static Price Parse(string csvData)

    //public static List<Price> ParseList(string csvData)
    //{
    //    var rows = csvData.Replace("\r", "").Split('\n');
    //    //the last empty row is ignored.
    //    return  rows.Take(rows.Count() - 1).Select(GetValues).ToList();

    //}

//    public static Price GetValues(string rows )
//    {

//        var cols = rows.Split(',');

//        Price p = new Price();
//        p.Symbol = cols[0];
//        p.Name = cols[1];
//        p.Bid = Convert.ToDecimal(cols[2]);
//        p.Ask = Convert.ToDecimal(cols[3]);
//        p.Open = Convert.ToDecimal(cols[4]);
//        p.PreviousClose = Convert.ToDecimal(cols[5]);
//        p.Last = Convert.ToDecimal(cols[6]);
//        p.Change = (p.PreviousClose - p.Ask) / p.PreviousClose;

//        return p;
//    }
//}

//public class TestDb : IRepository
//{
//    public List<Price> GetAllSecurityDataPoints()
//    {
//        var db = Database.OpenNamedConnection("mainDb");
//        var work = db.SecurityPrices.All();
//        return work;
//    }

//    public void Insert(Price sec)
//    {
//        var db = Database.OpenNamedConnection("mainDb");
//        db.SecurityPrices.Insert(sec);
//    }

//    public List<Price> GetAllSecurityDataPoints(string security)
//    {
//        var db = Database.OpenNamedConnection("mainDb");
//        var work = db.SecurityPrices.All();
//        return work;
//    }

}

//public class Price
//{
//    public string Symbol { get; set; }
//    public string Name { get; set; }
//    public decimal Bid { get; set; }
//    public decimal Ask { get; set; }
//    public decimal Open { get; set; }
//    public decimal PreviousClose { get; set; }
//    public decimal Last { get; set; }
//    public decimal Change { get; set; }
//}

