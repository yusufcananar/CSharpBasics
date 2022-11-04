using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypesAndVariables
{
    class Program
    {
        enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Math.Pow(2, 31) - 1);
            long num2 = (long)(Math.Pow(2, 63) - 1);
            short num3 = (short)(Math.Pow(2, 15) - 1);
            double num4 = Math.Pow(2, 63) - 1;
            decimal num5 = (decimal)Math.Pow(2, 63) - 1;
            bool cond = true;
            char num6 = 'A';
            byte num7 = 255;
            var num8 = 10;

            //Console.WriteLine("Hello World!");

            Console.WriteLine("{0} num{1} = {2}", num1.GetType(), 1, num1);
            Console.WriteLine("{0} num{1} = {2}", num2.GetType(), 2, num2);
            Console.WriteLine("{0} num{1} = {2}", num3.GetType(), 3, num3);
            Console.WriteLine("{0} num{1} = {2}", num4.GetType(), 4, num4);
            Console.WriteLine("{0} num{1} = {2}", num5.GetType(), 5, num5);
            Console.WriteLine("{0} num{1} = {2}", num6.GetType(), 6, num6);
            Console.WriteLine("{0} num{1} = {2}", num7.GetType(), 7, num7);
            Console.WriteLine("{0} num{1} = {2}", num8.GetType(), 8, num8);
            Console.WriteLine("{0} cond   = {1}", cond.GetType(), cond);
            Console.WriteLine("{0} day    = {1}", Days.Friday.GetType(), Days.Friday);

            Console.ReadLine();
        }
    }
}
