using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedClassTest
{
    class Program
    {

        protected class A
        {
            protected void method0()
            {
                Console.WriteLine();

            }
            public void method()
            {
                Console.WriteLine();

            }
        }

        protected class B : A
            {
                public void method2()
                {
                    method0();
                }

                protected void method3()
                {
                    Console.WriteLine();

                }

            }

         

        static void Main(string[] args)
        {

        }
    }
}
