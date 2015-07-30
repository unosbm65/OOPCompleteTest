using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapExample
{
    class Program
    {
    
  static void Main(string[] args)
        {

      // remove refs and test
            string[] words = "The quick brown fox".Split();


            string x = "Penn";
            string y = "Teller";
            Swap(ref x, ref y);
            Console.WriteLine(x);   // Teller
            Console.WriteLine(y);   // Penn
        }
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
      

    }
}
