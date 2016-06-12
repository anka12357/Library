using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue booksCatalogue = new BooksCatalogue();
            Catalogue comicsCatalogue = new ComicsCatalogue();
            Catalogue mediaCatalogue = new MediaCatalogue();

            int z = 0;
            while (z == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Katalog biblioteczny");
                Console.WriteLine("");
                Console.WriteLine("Wybierz katalog");
                Console.WriteLine("1. Katalog książek");
                Console.WriteLine("2. Katalog komiksów i mang");
                Console.WriteLine("3. Katalog multimediów");
                Console.WriteLine("4. Wyjście");

                int opcje = SafeRead.safeInt();

                switch (opcje)
                {
                    case 1:
                        booksCatalogue.menu();
                        break;

                    case 2:
                        comicsCatalogue.menu();
                        break;

                    case 3:
                        mediaCatalogue.menu();
                        break;

                    case 4:
                        z++;
                        break;

                    default:
                        Console.WriteLine("Zła opcja");
                        break;

                }

            }
        }
    }
}
