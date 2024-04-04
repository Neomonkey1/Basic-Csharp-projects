using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolLogic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line prints on the console
            Console.WriteLine("Please answer questions below to see if you qualify for insurance with us.");

            // This line gets input from the user and converts it to int variable
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            // This line gets input from the user, used escape characters and converts it to bool variable
            Console.WriteLine("Have you ever had a DUI? please answer \"true\" or \"false\"");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());

            // This line gets input from the user and converts it to int variable
            Console.WriteLine("How many speeding tickets do you have?");
            int userSpeed = Convert.ToInt32(Console.ReadLine());

            // Using variables from user to see if we get bool 'true' or 'false' using AND operators
            // Than printing results to console
            bool userQualified = userAge > 15 && userDUI == false && userSpeed <= 3;
            Console.WriteLine($"Thank you for your answers, it is {userQualified} that you qualify for insurance with us currently.");

            Console.ReadLine();
        }
    }
}
