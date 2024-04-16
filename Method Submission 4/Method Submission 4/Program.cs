using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Instantiate class 
            MathOperations math1 = new MathOperations();

            //  Call method from class and give it two numbers
            math1.DivideNumbers(25, 5);

            //  Call method from class and naming parameters while showing order does not effect output
            math1.DivideNumbers(num2: 10, num1: 200);


            Console.ReadLine();
        }
    }
}
