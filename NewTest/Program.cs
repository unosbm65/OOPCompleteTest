using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    public class A
    {
        public virtual void method1()
        {
            Console.WriteLine("base class");
        }
    }

    public class B : A
    {
        public new void method1()
        {
            Console.WriteLine("derived class");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.method1();


            B b = new B();
            b.method1();


            A c = new B();
            c.method1();


            Console.ReadLine();
        }
    }
}
