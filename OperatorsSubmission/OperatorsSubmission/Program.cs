using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate class and making two Employee objects
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, LastName = "Smith", FirstName = "Jane" };

            //  Comparing the two objects using the overloaded operators
            if (employee1 == employee2)
            {
                Console.WriteLine($"{employee1.FirstName} and {employee2.FirstName} have the same ID");
            }
            else
            {
                Console.WriteLine($"{employee1.FirstName} and {employee2.FirstName} do not have the same ID");
            }


            Console.ReadLine();
        }
    }
}
