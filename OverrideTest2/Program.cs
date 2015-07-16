using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTest2
{
    public class A
    {

        public virtual string Name { get; set; }

        public virtual string Family { get; set; }

        public virtual void method1()
        {
            Console.WriteLine("base class");
        }

        public virtual void method2()
        {
            Console.WriteLine("a class Name = " + Name);
            Console.WriteLine("a class Family = " + Family);
        }



    }

    public class B : A
    {
        public override string Name { get; set; }

        public new string Family { get; set; }
        public override void method1()
        {
            Console.WriteLine("derived class");
        }

        public override void method2()
        {
            Console.WriteLine("b class Name = " + Name);
            Console.WriteLine("b class Family = " + Family);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Name = "father name";
            a.Family = "a Family";
           


            B b = new B();
            b.Name = "child name";
            b.Family = "b Family";

            A c = new B();
            c.Name = "c name";
            c.Family = "c Family";
            

            a.method1();
            a.method2();
            Console.ReadLine();

            b.method1();
            b.method2();
            Console.ReadLine();

            c.method1();
            c.method2();

            Console.ReadLine();

        }
    }
}
