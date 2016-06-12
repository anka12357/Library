using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BooksCatalogue : Catalogue
    {
        List<Book> books = new List<Book>();


        public BooksCatalogue()
        {
            books.Add(new Book("Julian", "Tuwim", "Lokomotywa", ItemPlace.ReadingRoom));
            books.Add(new Book("Hans Christian", "Andersen", "Tylko grajek", ItemPlace.RentalStore));
            books.Add(new Book("Neil", "Gaiman", "Nigdziebądź", ItemPlace.RentalStore));
        }

        protected override void view()
        {
            books.Sort();
            int i = 1;

            foreach (Book k in books)
            {
                Console.WriteLine(i);
                Console.WriteLine("Autor: " + k.nameWriter + " " + k.surnameWriter);
                Console.WriteLine("Tytuł: " + k.title);
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
                Console.WriteLine("Katalog książek");
                Console.WriteLine("1. Wyświetl");
                Console.WriteLine("2. Dodaj książke");
                Console.WriteLine("3. Usuń książkę");
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
                        Console.WriteLine("Podaj miejsce (0 - czytelnia, 1 - wypożyczalnia)");
                        int place = SafeRead.safeInt();
                        ItemPlace itPlace = (ItemPlace)Enum.Parse(typeof(ItemPlace), place.ToString());
                        Book newBook = new Book(nameWriter, surnameWriter, title, itPlace);
                        books.Add(newBook);
                        break;

                    case 3:
                        view();
                        Console.WriteLine("Podaj, który rekord ma zosać usunięty");
                        try
                        {
                            int a = SafeRead.safeInt();
                            books.RemoveAt(a - 1);
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
