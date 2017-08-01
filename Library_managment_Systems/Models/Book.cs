using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_managment_Systems.Models
{
    public class Book
    {
        public int id { get; set; }
        public string  title { get; set; }
        public int SBIN { get; set; }
        public int NumberOfCopied { get; set; }

        public  string  describtion { get; set; }
    }
}