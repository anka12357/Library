using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class SafeRead
    {
        public static string safeString()
        {
            string s;
            do
            {
                s = Console.ReadLine();
            } while (s.Length == 0);
            return s;
        }

        public static int safeInt()
        {
            while (true)
            {
                try
                {
                    int i = int.Parse(Console.ReadLine());
                    return i;
                } catch (System.FormatException)
                {
                    Console.WriteLine("Musisz podać liczbę");
                }
            }
        }
    }
}
