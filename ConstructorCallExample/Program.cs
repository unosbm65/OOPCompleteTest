using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCallExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // debug with F11 to see outest constructor fires first then outer and then the inner
            DerivedClass2 d=new DerivedClass2();


            DerivedClass2 d2 = new DerivedClass2(10);

        }
    }

    //outest
    class BaseClass
    {
        public BaseClass ()
        {

        }
    }
    //outer
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            
        }
    }

    //inner
    class DerivedClass2 : DerivedClass
    {
        public DerivedClass2()
        {

        }
        public DerivedClass2(int x)
        {

        }
    }


}
