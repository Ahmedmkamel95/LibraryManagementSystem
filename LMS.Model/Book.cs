using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Model
{
    class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public int SBIN { get; set; }
        public int NumberOfCopied { get; set; }

        public string describtion { get; set; }
    }
}
