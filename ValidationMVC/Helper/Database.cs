using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationMVC.Helper
{
    static public class Database
    {
        public static List<string> Emails { get; set; }

        static Database()
        {
            Emails = new List<string>();
            Emails.Add("advani.gunjan@gmail.com");
            Emails.Add("advani.gunjan1@gmail.com");
            Emails.Add("advani.gunjan2@gmail.com");
            Emails.Add("advani.gunjan3@gmail.com");
        }
    }
}