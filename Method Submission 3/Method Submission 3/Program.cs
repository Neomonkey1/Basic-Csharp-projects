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
            //  Using Class MathOperation call method AddNumbers to take given values and performs operation
            
            MathOperation math1 = new MathOperation();
            
            //  Asking user for input, convert input to int variable
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            //  Asking user for second input or to skip, input to string variable, using IF ELSE statement,
            //  IF no input use IsNullOrEmpty() than use AddNumbers() with num1 value and second value is default value.
            //  print results on console, ELSE convert user input to int variable then print results on console.
            Console.WriteLine("If you like enter a second number (Press Enter to skip):");
            string input2 = Console.ReadLine();                 
            if ( string.IsNullOrEmpty(input2))
            {
                int results1 = math1.AddNumbers(num1);
                Console.WriteLine($"The result of input {num1} + 1 = {results1}.");
            }
            else
            {
                int num2 = Convert.ToInt32(input2);
                int results1 = math1.AddNumbers(num1,num2);
                Console.WriteLine($"The result of input {num1} + {num2} = {results1}.");
            }

            
            
            Console.ReadLine();
        }
    }
}
