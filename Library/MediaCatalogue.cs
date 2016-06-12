using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class MediaCatalogue : Catalogue
    {
        List<Media> media = new List<Media>();


        public MediaCatalogue()
        {
            media.Add(new Media("Julian", "Tuwim", "Lokomotywa", "film", ItemPlace.ReadingRoom));
            media.Add(new Media("Hans Christian", "Andersen", "Tylko grajek", "audiobook", ItemPlace.RentalStore));
            media.Add(new Media("Neil", "Gaiman", "Nigdziebądź", "audiobook", ItemPlace.RentalStore));
        }

        protected override void view()
        {
            int i = 1;

            foreach (Media k in media)
            {
                Console.WriteLine(i);
                Console.WriteLine("Twórca: " + k.nameCreator + " " + k.surnameCreator);
                Console.WriteLine("Tytuł: " + k.title);
                Console.WriteLine("Typ: " + k.type);
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
                Console.WriteLine("Katalog multimediów");
                Console.WriteLine("1. Wyświetl");
                Console.WriteLine("2. Dodaj");
                Console.WriteLine("3. Usuń");
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
                        Console.WriteLine("Podaj typ (np.: film, audiobook itp.");
                        string type = SafeRead.safeString();
                        Console.WriteLine("Podaj miejsce (0 - czytelnia, 1 - wypożyczalnia)");
                        int place = SafeRead.safeInt();
                        ItemPlace itPlace = (ItemPlace)Enum.Parse(typeof(ItemPlace), place.ToString());

                        Media newMedia = new Media(nameWriter, surnameWriter, title, type, itPlace);
                        media.Add(newMedia);
                        break;

                    case 3:
                        view();
                        Console.WriteLine("Podaj, który rekord ma zosać usunięty");
                        try
                        {
                            int a = SafeRead.safeInt();
                            media.RemoveAt(a - 1);
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
