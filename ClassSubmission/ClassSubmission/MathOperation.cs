using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class MathOperation
    {
        //  Above made class public
        //  Method public void, takes 1 parameter, perform operation and print result to console
        public void DivideBy2(int num1)
        {
            int results = num1 / 2;
            Console.WriteLine($"Result of {num1} divide by 2 equals: {results}");
        }

        //  Method public void, takes 1 parameter and 1 output parameter, perform operation and gets output parameter
        public void AddByTen(int num1, out int output )
        {
            output = num1 + 10;
        }

        //  Overload method public void by making parameter a double, perform operation and print result to console.
        public void AddByTen(double num1)
        {
            double result = num1 + 10;
            Console.WriteLine($"Result from using type double {num1} + 10 equals: {result} ");

        }
    }
}
