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

            //  Using switch statement, code will go through each 'case' till it gets to the right one then break out of the program,
            //  If nothing is picked switch statement will go with default.
            int day = 5;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;

            }


            Console.ReadLine();
        }
    }
}
