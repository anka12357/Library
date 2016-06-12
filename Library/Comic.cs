using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class Comics : Item
    {
        public string nameWriter { get; set; }
        public string surnameWriter { get; set; }
        public string title { get; set; }
        public int volume { get; set; }

        public Comics(string nameWriter, string surnameWriter, string title, int volume, ItemPlace place)
        {
            this.nameWriter = nameWriter;
            this.surnameWriter = surnameWriter;
            this.title = title;
            this.volume = volume;
            this.place = place;
        }
    }
}
