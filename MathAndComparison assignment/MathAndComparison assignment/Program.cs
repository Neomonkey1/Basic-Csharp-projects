using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line prints to screen.
            Console.WriteLine("Anonymous Income Comparison Program");

            // Takes inputs for Person 1 from user, converts to decimal and stores in variable.
            Console.WriteLine("What is Person 1 hourly rate?");
            decimal person1HR = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours did Person 1 work?");
            decimal person1HW = Convert.ToDecimal(Console.ReadLine());

            // Takes inputs for Person 2 from user, converts to decimal and stores in variable.
            Console.WriteLine("What is Person 2 hourly rate?");
            decimal person2HR = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours did Person 2 work?");
            decimal person2HW = Convert.ToDecimal(Console.ReadLine());

            // Takes variables from Person1 and multiplies them to get weekly pay variable than multiplies that by 52 for weeks in a year to get annual variable.
            decimal person1weekly = person1HR * person1HW;
            decimal person1Annual = person1weekly * 52;

            // Takes variables from Person2 and multiplies them to get weekly pay variable than multiplies that by 52 for weeks in a year to get annual variable.
            decimal person2weekly = person2HR * person2HW;
            decimal person2Annual = person2weekly * 52;

            // Prints results of Person1annual
            Console.WriteLine("Annual salary of Person 1: " + person1Annual);

            // Prints results of Person2annual
            Console.WriteLine("Annual salary of Person 2: " + person2Annual);

            // Uses bool logic to compare person1Annual and person2Annual and print results to console.
            bool makesMore = person1Annual > person2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + makesMore);

            Console.ReadLine();
        }
    }
}
