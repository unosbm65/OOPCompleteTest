using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {

           int x =  Foo(10);
            Console.WriteLine(x + "     "   + x.GetType().FullName);
            Console.ReadLine();
        }

        static int Foo<T>(T x)
        {
            return (int)(object)x;
            //return (int)x;               // compile time error
        }  


    }
}
