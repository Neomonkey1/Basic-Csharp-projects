using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  This line prints to console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            //  This line asks for user input, converts string input to int variable then uses IF statement to end program if > 50
            Console.WriteLine("Please enter the weight of your package:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            //  This will ask for user input and convert string input to int variable packageWidth
            Console.WriteLine("Please enter the width of your package:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            //  This will ask for user input and convert string input to int variable packageHeight
            Console.WriteLine("Please enter the height of your package:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            //  This will ask for user input and convert string input to int variable packageLength
            Console.WriteLine("Please enter the length of your package:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //  Adds int variables to get packageDimension result
            int packageDimension = packageWidth + packageHeight + packageLength;

            //  Using IF statement to end program if result > 50
            if (packageDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            //  Multiple all converted user inputs variables then divide by 100 to get Cost result, than convert int to decimal variable
            int packageCost = packageWidth * packageHeight * packageLength * packageWeight / 100;
            decimal deliverCost = packageCost;           

            //  This line gives the user the estimated cost using decimal variable, used ToString("F2") to show result with 2 decimal spots,
            //  used escape character to display 'Thank you' on new line.
            Console.WriteLine($"Your estimated total for shipping this package is: ${deliverCost.ToString("F2")} \nThank you!");


            Console.ReadLine();
        }
    }
}