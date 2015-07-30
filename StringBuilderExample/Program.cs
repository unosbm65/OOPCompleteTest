using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
       

       static void Main(string[] args)
        {

           Test t=new Test();
           t.Testmethod(t);
           Console.WriteLine(t.i.ToString());    // test










            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine(sb.ToString());    // test
        }


        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
 

       

    }


    internal class Test
    {
        public int i { get; set; }

        public void Testmethod(Test x)
        {
            x.i = 10;
            x = null;
        }
    }

}
