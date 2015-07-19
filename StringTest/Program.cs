using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c=new MyClass();
            c.m1();

        }

        class MyClass
        {
            
            public void m1()
            {
                var str = "ali";
                Console.WriteLine(str);
                m2(ref str);
                Console.WriteLine(str);
                Console.ReadLine();
            }


            public void m2(ref string name)
            {
                var s = name;
                name = "changed name";

            }
        }

    }
}
