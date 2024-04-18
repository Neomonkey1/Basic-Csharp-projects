using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate an Employee object with type string as generic parameter
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "Pencil", "Pen", "Paper", "Ruler" };

            //  Instantiate an Employee object with type int as generic parameter
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int> { 1, 2, 3, 4 };

            //  Using FOREACH loop to display all things from string List
            Console.WriteLine("Employee objects as \"string\": ");
            foreach (string thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            //  Using FOREACH loop to display all things from int List
            Console.WriteLine("\nEmployee objects as \"int\": ");
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

        }
    }
}
