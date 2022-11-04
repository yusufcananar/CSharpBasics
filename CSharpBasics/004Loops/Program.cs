using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 132;
            bool res = IsNumberPrime(myNum);

            if (res)
            {
                Console.WriteLine("It's a prime number.");
            }
            else
            {
                Console.WriteLine("It's NOT a prime number.");
            }
            
            Console.ReadLine();
        }

        static bool IsNumberPrime(int num)
        {
            bool res = false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    res = false;
                    break;
                }
                else
                {
                    res = true;
                }
            }
            return res;
        }
    }
}
