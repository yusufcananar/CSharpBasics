using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated.");
        }
    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("mySql added.");
        }

        public void Delete()
        {
            Console.WriteLine("mySql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("mySql updated.");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated.");
        }

    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
