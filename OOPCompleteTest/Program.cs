using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPCompleteTest
{
    class Program
    {

        private class A
        {
            public void method1()
            {
                Console.WriteLine("a class");
            }
        }

        private class B
        {
            public void method1()
            {
                Console.WriteLine("b class");
            }

        }



        static void Main(string[] args)
        {
            A a=new A();
            a.method1();


            B b=new B();
            b.method1();



            Console.ReadLine();


        }
    }
}
