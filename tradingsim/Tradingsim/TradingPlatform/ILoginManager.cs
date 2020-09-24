using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
//Polymorphism concept
namespace TradingPlatform
{
    public interface ILoginManager
    {
        bool Login(string username, string password);
    }
    //class in interface used to allow guarunteed login access when testing solution for administration.
    public class AlwaysAllowToLoginManager : ILoginManager
    {
        public bool Login(string username, string password)
        {
            return true;
        }
    }
   
    //class used to verify user's login details. 
    public class CsvLoginManager : ILoginManager
    {
        public CsvLoginManager()
        {
            //Open the excel file that contains the Login details of all users.
            var reader = new StreamReader(File.OpenRead(@"F:\tradingsim\Tradingsim\TradingPlatform\db\user_db.csv"));
            var userpwords = new Dictionary<string, string>();
            while (!reader.EndOfStream)
            {
                //reads the characters in the excel file and returns the data as data type string in the array 'splits'.
                var userNamePword = reader.ReadLine();
                var splits = userNamePword.Split(',');
                if (splits.Count() >= 2)
                    //Username and passwords are added to the dictionary.
                    userpwords.Add(splits[0], splits[1]);
            }
            //line of coding to skip the first line of coding, this being the attributes in the excel file.
            //Creates a dictionary according to the specified range of keys below.
            UserList = userpwords.Skip(1)
                .ToDictionary(x => x.Key, x => x.Value);
        }
        //Implements the skipped line into the dictionary.
        public Dictionary<string, string> UserList { get; private set; }

        public bool Login(string username, string password)
        {
            return UserList.Any(x => x.Key == username && x.Value == password);
        }
    }
    //Database login manager not implemented as of yet.
    public class DbLoginManager : ILoginManager
    {
        public bool Login(string username, string password)
        {   
            // if the class was to be added to be called the error it is not implemented will be displayed.
            throw new NotImplementedException();
        }

    }
}