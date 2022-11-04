using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 17;

            int x = 1;
            int y = 0;

            var res = Sub(ref num1, ref num2);

            Console.WriteLine(res);
            Console.WriteLine("x : {0}, y : {1}", num1, num2);

            Console.WriteLine(Multiply(out x, out y));
            Console.WriteLine("x : {0}, y : {1}", x, y);

            Console.WriteLine(Add(2,3,4));
            Console.ReadLine();
        }

        static int Sub(ref int num1, ref int num2)
        {
            Console.WriteLine("x : {0}, y : {1}", num1, num2);
            return num1 - num2;
        }

        static int Multiply(out int x, out int y)
        {
            x = 20;
            y = 11;
            Console.WriteLine("x : {0}, y : {1}", x, y);
            return x * y;
        }

        static int Add(int x=0, int y=0)
        {
            return x + y;
        }

        static int Add(params int[] nums) //Overloads the other Add function by taking endless parameters as array
        {
            return nums.Sum();
        }
    }
}
