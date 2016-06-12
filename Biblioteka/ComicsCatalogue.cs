using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ComicsCatalogue : Catalogue
    {
        List<Comics> comics = new List<Comics>();


        public ComicsCatalogue()
        {
            comics.Add(new Comics("Julian", "Tuwim", "Lokomotywa", 3, ItemPlace.RentalStore));
            comics.Add(new Comics("Hans Christian", "Andersen", "Tylko grajek", 32, ItemPlace.ReadingRoom));
            comics.Add(new Comics("Neil", "Gaiman", "Nigdziebądź", 1, ItemPlace.ReadingRoom));
        }

        protected override void view()
        {
            int i = 1;

            foreach (Comics k in comics)
            {
                Console.WriteLine(i);
                Console.WriteLine("Autor: " + k.nameWriter + " " + k.surnameWriter);
                Console.WriteLine("Tytuł: " + k.title + ", tom " + k.volume);
                Console.WriteLine("Miejsce: " + k.getPlace());
                Console.WriteLine("");
                i++;
            }
        }

        public override void menu()
        {

            int y = 0;
            while (y == 0)
            {
                Console.WriteLine("Katalog komiksów i mang");
                Console.WriteLine("1. Wyświetl");
                Console.WriteLine("2. Dodaj komiks/mangę");
                Console.WriteLine("3. Usuń komiks/mangę");
                Console.WriteLine("4. Powrót do poprzedniego menu");

                int choice = SafeRead.safeInt();

                switch (choice)
                {
                    case 1:
                        view();
                        break;

                    case 2:
                        Console.WriteLine("Podaj imię autora");
                        string nameWriter = SafeRead.safeString();
                        Console.WriteLine("Podaj nazwisko autora");
                        string surnameWriter = SafeRead.safeString();
                        Console.WriteLine("Podaj tytuł");
                        string title = SafeRead.safeString();
                        Console.WriteLine("Podaj tom");
                        int volume = SafeRead.safeInt();
                        Console.WriteLine("Podaj miejsce (0 - czytelnia, 1 - wypożyczalnia)");
                        int place = SafeRead.safeInt();
                        ItemPlace itPlace = (ItemPlace)Enum.Parse(typeof(ItemPlace), place.ToString());

                        Comics newComics = new Comics(nameWriter, surnameWriter, title, volume, itPlace);
                        comics.Add(newComics);
                        break;

                    case 3:
                        view();
                        Console.WriteLine("Podaj, który rekord ma zosać usunięty");
                        try
                        {
                            int a = SafeRead.safeInt();
                            comics.RemoveAt(a - 1);
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Nie ma takiego numeru");
                        }
                        break;

                    case 4:
                        y++;
                        break;

                    default:
                        Console.WriteLine("Zła opcja");
                        break;
                }
            }

        }
    }
}
