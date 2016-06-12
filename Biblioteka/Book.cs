using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : Item, IComparable<Book>
    {
        public string nameWriter { get; set; }
        public string surnameWriter { get; set; }
        public string title { get; set; }

        public Book(string nameWriter, string surnameWriter, string title, ItemPlace place)
        {
            this.nameWriter = nameWriter;
            this.surnameWriter = surnameWriter;
            this.title = title;
            this.place = place;
        }

        public int CompareTo(Book other)
        {
            return this.title.CompareTo(other.title);
        }
    }
}
