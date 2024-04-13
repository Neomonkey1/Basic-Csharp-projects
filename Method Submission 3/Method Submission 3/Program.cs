using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Asking user for input, convert input to int variable
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            //  Asking user for second input or to skip, input to string variable, using ternary operator (?)
            //  if user skips input uses default value 1 otherwise converts input to int variable
            Console.WriteLine("If you like enter a second number (Press Enter to skip):");
            string input2 = Console.ReadLine();
            int num2 = string.IsNullOrEmpty(input2) ? 1 : Convert.ToInt32(input2);

            //  Using Class MathOperation call method AddNumbers to take given values and performs operation
            //  returns value to int variable
            MathOperation math1 = new MathOperation();
            int results1 = math1.AddNumbers(num1, num2);

            //  Print to console results
            Console.WriteLine($"The result of input {num1} + {num2} = {results1}.");
            Console.ReadLine();
        }
    }
}
