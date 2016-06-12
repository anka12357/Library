using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Item
    {
        public ItemPlace place { get; set; }

        public string getPlace()
        {
            if (place == ItemPlace.RentalStore)
                return "wypożyczalnia";
            else
                return "czytelnia";
        }
    }

    public enum ItemPlace { ReadingRoom, RentalStore }
}
