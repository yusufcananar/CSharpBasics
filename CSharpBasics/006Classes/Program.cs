using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            Customer customer1 = new Customer();
            customer1.City = "Ankara";
            customer1.Id = 9;
            customer1.FirstName = "Anakin";
            customer1.LastName = "Skywalker";

            Customer customer2 = new Customer
            {
                City = "Naboo",
                Id = 11,
                FirstName = "Padmé",
                LastName = "Amidala"
            };


            customer2.systemId = 16;
            Console.WriteLine(customer2.systemId);
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated.");
        }
    }
}
