using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            //ListDemo();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("computer", "Bilgisayar");
            dict.Add("table", "masa");
            dict.Add("book", "kitap");


            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
            }

            var res = dict.ContainsKey("table");
            Console.WriteLine(res); 

            Console.ReadLine();
        }

        private static void ListDemo()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İzmir");

            Console.WriteLine(cities.Contains("İzmir"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer> {
                (new Customer { Id = 0, Address = "B", Name = "Yusuf" }),
                (new Customer { Id = 1, Address = "C", Name = "Dilek" })
            };

            //List<Customer> customers2 = new List<Customer>();
            customers.Add(new Customer { Id = 3, Address = "B", Name = "Padme" });
            customers.Add(new Customer { Id = 4, Address = "C", Name = "Anakin" });

            Customer customer1 = new Customer { Id = 7, Address = "S", Name = "Obi" };
            customers.Add(customer1);


            customers.AddRange(new Customer[]
            {
                (new Customer { Id = 5, Address = "B", Name = "Yoda" }),
                (new Customer { Id = 6, Address = "C", Name = "R2D2" })
            });


            customers.Add(customer1);

            customers.Insert(0, customer1);

            //customers.Clear();
            var count = customers.Count();
            Console.WriteLine("count : {0}", count);

            Console.WriteLine(customers.Contains(customer1));

            customers.Remove(customer1);

            customers.RemoveAll(c => c.Name == "Obi");

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);

            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("Index : {0}", index2);



            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        private static void ArrayListDemo()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");



            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(cities[2]);

            Console.ReadLine();
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
    }
}
