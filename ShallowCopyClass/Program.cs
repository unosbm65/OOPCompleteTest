using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of clsShallow and assign values to its fields.
            clsShallow objshallow = new clsShallow();
            objshallow.Age = 25;
            objshallow.EmployeeName = "Ahmed Eid";

            // add the ref value to the objshallow 
            clsRefSalary clsref = new clsRefSalary(1000);
            objshallow.EmpSalary = clsref;

            // Performs a shallow copy of m1 and assign it to m2.
            clsShallow m2 = objshallow.CreateShallowCopy(objshallow);

            // then modify the clsref salary value to be 2000
            clsref.Salary = 2000;
            m2.EmployeeName = "unos baghaii";
            m2.Age = 100;

            // so the m1 object salary value become 2000
            int EmpSalary = objshallow.EmpSalary.Salary;


            Console.ReadLine();


        }



        public class clsShallow
        {
            public static string CompanyName = "My Company";
            public int Age;
            public string EmployeeName;
            public clsRefSalary EmpSalary;

            public clsShallow CreateShallowCopy(clsShallow inputcls)
            {
                return (clsShallow)inputcls.MemberwiseClone();
            }
        }
        public class clsRefSalary
        {
            public clsRefSalary(int _salary)
            {
                Salary = _salary;
            }
            public int Salary;
        }
    }
}
