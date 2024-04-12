using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Creating an instance of the class. Calling the three methods within the class
            MathOperation math1 = new MathOperation();
            int results1 = math1.AddNumbers(15);
            int results2 = math1.MultiplyNumbers(5);
            string results3 = math1.DivideString("20");

            //  Printing to console what operating is being done and the results of methods used 
            Console.WriteLine($"Using method to add 25 and 15 equals {results1}");
            Console.WriteLine($"Using method to multiply 5 by 4 equals {results2}");
            Console.WriteLine($"Using method to take string \"20\" convert to int and divide it by 3 then convert back to string the answer: {results3}");



            Console.ReadLine();
        }
    }
}
