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

            var x = default (char);



            Console.WriteLine(string.Equals("ṻ", "ǖ", StringComparison.CurrentCulture));
            Console.ReadLine();



            string a = "a" + 8;
            Console.WriteLine(a);

           

            TestStringImmutable c = new TestStringImmutable();
            c.m1();

            
            

            TestString T = new TestString();
            T.m1();
        }

        class TestStringImmutable
        {
            
            public void m1()
            {
                var str = "ali";
                Console.WriteLine("TestStringImmutable =  before calling method str is =  " + str);
                m2(str);
                Console.WriteLine("TestStringImmutable =  after calling method str is =  " + str);
                Console.ReadLine();
            }


            public void m2(string name)
            {
                var s = name;
                name = "changed name";
                Console.WriteLine("inside the method name is =  " + name);

            }
        }
        class TestString
        {

            public void m1()
            {
                var str = "ali";
                Console.WriteLine("TestString  with ref=  before calling method str is =  " + str);
                m2(ref str);
                Console.WriteLine("TestString with ref =  after calling method str is =  " + str);
                Console.ReadLine();
            }


            public void m2(ref string name)
            {
                var s = name;
                name = "changed name";
                Console.WriteLine("inside the method name is =  " + name);

            }
        }

    }
}
