using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Antalya" };
            string[] cities2 = new string[] { "Aydın", "İzmir", "Mersin" };
            cities2 = cities1;

            cities1[2] = "Rize";
            Console.WriteLine(cities2[2]);

            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;


            Console.ReadLine();
        }
    }
}
