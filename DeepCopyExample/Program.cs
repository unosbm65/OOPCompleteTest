using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopyExample
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates an instance of clsDeep and assign values to its fields.
            clsDeep objdeep = new clsDeep();
            objdeep.Age = 25;
            objdeep.EmployeeName = "Ahmed Eid";

            // add the ref value
            clsRefSalary clsref = new clsRefSalary(1000);
            objdeep.EmpSalary = clsref;

            // Performs a shallow copy of m1 and assign it to m2.
            clsDeep m2 = objdeep.CreateDeepCopy(objdeep);


            m2.EmpSalary =new clsRefSalary(9000);



            // then modify the clsref salary value to be 2000 
            clsref.Salary = 2000;

            // so the m1 object salary value become 2000
            int EmpSalary = objdeep.EmpSalary.Salary;



            clsDeep m3 = DeepCopy(objdeep);

            m3.EmpSalary=new clsRefSalary(1000000);

        }

        public static T DeepCopy<T>(T item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, item);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }

    }


    [Serializable]
    // serialize the classes in case of deep copy
    public class clsDeep
    {
        public static string CompanyName = "My Company";
        public int Age;
        public string EmployeeName;
        public clsRefSalary EmpSalary;
        public clsDeep CreateDeepCopy(clsDeep inputcls)
        {
            MemoryStream m = new MemoryStream();
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(m, inputcls);
            m.Position = 0;
            return (clsDeep)b.Deserialize(m);
        }

      

    }

    [Serializable]
    public class clsRefSalary
    {
        public clsRefSalary(int _salary)
        {
            Salary = _salary;
        }
        public int Salary;
    }





    // I found a very smart method for performing deep copy
    /// <summary>
/// Using generics will solve some performance issues
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="item"></param>
/// <returns></returns>
//public static T DeepCopy<T>(T item)
//{
//    BinaryFormatter formatter = new BinaryFormatter();
//    MemoryStream stream = new MemoryStream();
//    formatter.Serialize(stream, item);
//    stream.Seek(0, SeekOrigin.Begin);
//    T result = (T)formatter.Deserialize(stream);
//    stream.Close();
//    return result;
//}


}
