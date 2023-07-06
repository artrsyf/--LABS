using System;
using System.Collections.Generic;

namespace Lab11
{
    class Book
    {
        public int    Id     { get; set; }
        public double Price  { get; set; }
        public string Title  { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return "id="+Id+" price="+Price+"$  "+Author+" : "+Title;
        }
    }
}
