using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginExample
{
    class Program
    {

        public delegate int Del(int x);


        static void Main(string[] args)
        {


        }
    }



    class Test
    {

        public void Method()
        {

        }



    }


    internal class Plugin1
    {
        public T Method1<T>(T x)
        {

            return x;
        }
    }
    internal class Plugin2
    {
        public T Method1<T>(T x)
        {

            return x;
        }
    }
}
