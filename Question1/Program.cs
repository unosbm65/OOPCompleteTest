using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {

       Test2 t=new Test2();
            t.test();
        }







    }

    internal class Test2
    {
        public void test()
        {

            test tt = new test("ali");
            Console.WriteLine(tt.str);

            test2(ref tt);

        }

        public void test2(ref test t)
        {
            t = new test("reza");
            Console.WriteLine(t.str);
        }

    }



    internal class test
    {
        public string str { get; set; }

        public test(string t)
        {
            str = t;
        }

    }



}
