using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass M=new MyClass();
            M.Age = 10;
            M.Name = "unos";


            MyClass A = new MyClass();
            A.Age = 20;
            A.Name = "reza";


            M = A;   // they point to the same place in memory


            A = null;   // A got null but M's reference to memory is alive. check M

            M.Update(30,"meysam");

           M.Update2(M);
            





            Console.ReadLine();


        }



        class MyClass
        {
            public int Age { get; set; }
            public string Name { get; set; }



            public void Update(int Age,string Name)
            {
                this.Age = Age;
                this.Name = Name;
            }

            public void Update2(MyClass inst)
            {
                inst.Age = 40;
                inst.Name = "elyas";
            }
        }
    }
}
