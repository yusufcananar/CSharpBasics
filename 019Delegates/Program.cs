using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019Delegates
{

    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int num1, int num2);

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.ShowAlert;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;


            
            myDelegate2("King Arthur");
            myDelegate();

            myDelegate3 += matematik.Carp;
            var x = myDelegate3(5, 6);

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string txt)
        {
            Console.WriteLine("Hello! {0}",txt);
        }

        public void ShowAlert2(string txt)
        {
            Console.WriteLine("Be careful!{0}", txt);
        }
    }

    public class Matematik
    {
        public int Topla(int num1, int num2)
        {
            var res = num1 + num2;
            Console.WriteLine("Topla : {0}", res);
            return res;
        }

        public int Carp(int num1, int num2)
        {
            var res = num1 * num2;
            Console.WriteLine("Carp : {0}", res);
            return res;
        }
    }
}
