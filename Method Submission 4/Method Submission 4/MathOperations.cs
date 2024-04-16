using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_4
{
    public class MathOperations
    {
        //  Above made class public
        //  Made method public void and to take two parameters
        public void DivideNumbers(int num1, int num2)
        {
            //  Method operation is taking parameter num1 and divide by 3 and print to console,
            //  also take parameter num2 and print it to console.
            int results1 = num1 / 3;
            Console.WriteLine($"The result of {num1} divide by 3 equals: {results1}");
            Console.WriteLine($"The second input was {num2}");
        }
    }
}
