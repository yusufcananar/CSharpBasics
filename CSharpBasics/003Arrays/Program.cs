using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Dilek", "Yusuf", "Bo" };
            students[2] = "Kedo";

            foreach (var st in students)
            {
                Console.WriteLine(st);
            }

            string[,] regions = new string[3, 3]
            {
                { "Hong Kong", "Miami", "Ankara"},
                { "Antalya", "Colorado", "Oslo"},
                { "Tokyo", "Adana", "Poznan"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("--------------------------");
            }

            Console.ReadLine();

        }
    }
}
