using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _018Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //var res1 = dortIslem.Topla2();
            //var res2 = dortIslem.Topla(3, 5);

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 6, 7);
            //var res1 = dortIslem.Topla(7, 5);
            //var res2 = dortIslem.Topla2();

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);


            var instance = (DortIslem)Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            var res1 = methodInfo.Invoke(instance, null);
            Console.WriteLine(res1);


            Console.WriteLine("#######################################");
            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine(" --> Param : {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine(" --> Attribute Name : {0}", attribute);
                }
            
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem()
        {

        }
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
