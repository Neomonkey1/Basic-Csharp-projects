using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    //  Made class Program static
    static class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate Class 
            MathOperation math1 = new MathOperation();

            //  Asking user for input, convert input to int variable
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //  Calling method and using user input for parameter
            math1.DivideBy2(num1);

            //  Making output variable. 
            //  Calling method and using user input for parameter, getting output from method and printing to console the result
            int output;
            math1.AddByTen(num1, out output);
            Console.WriteLine($"Getting result of {num1} + 10 equals: {output}");

            //  Calling overload method, using input double value 
            math1.AddByTen(15.55);




            Console.ReadLine();
        }
    }
}
