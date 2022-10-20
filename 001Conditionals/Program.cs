using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 7;

            if (num >= 0 && num <= 100)
            {
                if (num >= 10 && num <= 20)
                {
                    Console.WriteLine("Num is exactly between 10 to 20");
                }
                else
                {
                    Console.WriteLine("Num is definetely not between 10 to 20");
                }
            }
            else
            {
                Console.WriteLine("Num is out of bounds!");
            }

            Console.ReadLine();
        }
    }
}
