using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassTest
{
    class Program
    {
        public class A
        {

            public void method()
            {
                Console.WriteLine("a class");
            }


            public void method2()
            {
                B b=new B();
                b.method();
            }

            private class B
            {

                public void method()
                {
                    Console.WriteLine("b class");
                }

            }
        }

        static void Main(string[] args)
        {
            A a=new A();
            a.method();
            Console.ReadLine();


            a.method2();
            Console.ReadLine();



        }
    }
}
