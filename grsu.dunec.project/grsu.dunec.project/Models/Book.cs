using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace grsu.dunec.project.Models
{
    public class Book
    {
        public enum BookType
        {
            Paper,Electronic
        }
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int price { get; set; }
        public BookType type { get; set; }
        public int yearOfPublishing { get; set; }
        public double rating { get; set; }

    }
}