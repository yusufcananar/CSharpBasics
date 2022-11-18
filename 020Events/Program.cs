using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product hdd = new Product(50);
            hdd.ProductName = "Hard Disk Drive";

            Product ssd = new Product(50);
            ssd.ProductName = "Solid State Drive";
            ssd.StockControlEvent += Ssd_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                hdd.Sell(10);
                ssd.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Ssd_StockControlEvent()
        {
            Console.WriteLine("SSD stock about to finish.");
        }
    }
}
