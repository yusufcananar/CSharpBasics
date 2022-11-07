using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int Id { get; set; }
        private string Name { get; set; }
        public void Save()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {            
            Customer customer = new Customer();
            customer.Save();
        }
    }

    public class Course
    {
        public string Name { get; set; }
    }
}
