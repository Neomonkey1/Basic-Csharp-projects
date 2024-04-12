using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Asking the user for input convert input to int variable.
            Console.WriteLine("Pick a number to perform operations on.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            MathOperations mathOperations1 = new MathOperations();
            int result1 = mathOperations1.AddNumber(userNum);
            int result2 = mathOperations1.SubtractNumber(userNum);
            int result3 = mathOperations1.MultiplyNumber(userNum);

            Console.WriteLine($"you entered {userNum} we added 10 to equal {result1}");
            Console.WriteLine($"you entered {userNum} we subtract 5 to equal {result2}");
            Console.WriteLine($"you entered {userNum} we multiply by 2 to equal {result3}");




            Console.ReadLine();
        }
    }
}
