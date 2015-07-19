using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow_Underflow
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {


                //byte x = 200;
                //byte y = 200;
                //byte z = (byte) (x + y);




                byte a = 9, b = 9;
                byte c = (byte) (a + b + -100);

                Console.ReadLine();
            }
        }
    }
}
