using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variable
            string name = "Ray";

            // using if, else if and else statements to check for several conditions
            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is Brett");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse or Brett");
            }

            // using the not equal operator
            if (1 != 2)
            {
                Console.WriteLine("All good, math still works.");
            }
            else
            {
                Console.WriteLine("What do we do math doesn't work!");
            }

            // Using the ternary operator '?'
            int num1 = 7;
            int num2 = 12;
            // in ternary operator the first value is True : the second value is False so the operator will pick the value based off if the results is True or False.
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
