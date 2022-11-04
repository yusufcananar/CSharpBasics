using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal(),
                new MysqlCustomerDal()
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }
            
            //InterfaceDemo();

            //InterfaceIntro();

            Console.ReadLine();

        }

        private static void InterfaceDemo()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfaceIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Anakin",
                LastName = "Skywalker",
                Address = "Naboo"
            };

            personManager.Add(customer);
            personManager.Add(new Student { Id = 2, FirstName = "Padmé", LastName = "Amidala", Department = "Cenatour" });
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }

        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }

        }

        class Worker: IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
