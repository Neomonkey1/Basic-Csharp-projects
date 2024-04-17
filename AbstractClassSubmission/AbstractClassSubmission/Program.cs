using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate superclass and giving object values
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //  Calling superclass method
            employee.SayName();

            //  using polymorphism to create an object of type IQuittable,
            //  calling method from class Employee inherit from interface IQuittable
            IQuittable quittable = employee;
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
