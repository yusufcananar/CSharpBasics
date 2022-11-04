using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            foreach (var letter in city)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine(String.Format("{0} {1}", city , "TR"));


            string sentence = "May the force be with you.";

            var res1 = sentence.Length;
            var res2 = sentence.Clone();
            bool res3 = sentence.EndsWith("you.");
            bool res4 = sentence.StartsWith("Master");
            var res5 = sentence.IndexOf("force");
            var res6 = sentence.IndexOf(" ");
            var res7 = sentence.LastIndexOf(" ");
            sentence = sentence.Remove(res1 - 1);
            var res8 = sentence.Insert(res1 - 1, ", Master!");
            var res9 = sentence.Substring(1, 4);
            var res10 = sentence.ToUpper();
            var res11 = sentence.ToLower();
            var res12 = sentence.Replace(" ", "*");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
            Console.WriteLine(res7);
            Console.WriteLine(res8);
            Console.WriteLine(res9);
            Console.WriteLine(res10);
            Console.WriteLine(res11);
            Console.WriteLine(res12);

            Console.ReadLine();
        }
    }
}
