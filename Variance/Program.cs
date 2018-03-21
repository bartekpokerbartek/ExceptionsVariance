using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Employee>(); // Not for instances
            IEnumerable<object> objects = new List<int>(); // Not for value types

            //Assignment compatibility
            string str = "test";
            object obj = str;

            // Covariance.
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type argument
            // is assigned to an object instantiated with a less derived type argument.
            // Assignment compatibility is preserved.
            IEnumerable<object> objectzzz = strings;

            // Contravariance.           
            Action<object> actObject = SetObject;
            Action<string> actString = actObject;

            //link: https://msdn.microsoft.com/en-us/library/dd799517(v=vs.100).aspx#InterfaceCovariantTypeParameters

            object[] ob = new String[10]; //array covariance


            ISomeInterface<Employee> employee = new Emp();
            ISomeInterface<Person> person = employee;
        }

        static void SetObject(object obj) { }
    }

    

    internal class Person
    {
    }

    internal class Employee : Person
    {
    }

    interface ISomeInterface<out T>
    {
    }

    class Emp : ISomeInterface<Employee>
    {
    }
}
