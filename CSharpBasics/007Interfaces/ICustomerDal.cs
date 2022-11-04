using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Interfaces
{
    internal interface ICustomerDal
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

    class OracleCustomerDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }
    }

    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("mysql added.");
        }

        public void Delete()
        {
            Console.WriteLine("mysql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("mysql updated.");
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
