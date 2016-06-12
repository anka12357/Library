using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Media : Item
    {
        public string nameCreator { get; set; }
        public string surnameCreator { get; set; }
        public string title { get; set; }
        public string type { get; set; }

        public Media(string nameWriter, string surnameWriter, string title, string type, ItemPlace place)
        {
            this.nameCreator = nameWriter;
            this.surnameCreator = surnameWriter;
            this.title = title;
            this.type = type;
            this.place = place;
        }
    }
}
