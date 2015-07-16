using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideTest
{

    public class A
    {

        public string Name  { get; set; }

        public virtual void method1()
        {
            Console.WriteLine("base class");
        }

        public virtual void method2()
        {
            Console.WriteLine("a class = " + Name);
        }



    }

    public class B : A
    {
        public string Name { get; set; }
        public override void method1()
        {
            Console.WriteLine("derived class");
        }

        public override  void method2()
        {
            Console.WriteLine("b class = " + Name);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Name = "a name";
            a.method1();
            a.method2();
            Console.ReadLine();


            B b = new B();
            b.Name = "b name";
            b.method1();
            b.method2();
            Console.ReadLine();




            // note : A is instantiated and its name initialized but method2 is overriden and name is empty in that scop
            A c = new B();
            c.Name = "c name";
            c.method1();
            c.method2();

            Console.ReadLine();

        }
    }
}
