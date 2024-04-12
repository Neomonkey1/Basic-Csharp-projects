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
            MathOperation math1 = new MathOperation();
            int results1= math1.AddNumbers(15);


            Console.WriteLine(results1);



            Console.ReadLine();
        }
    }
}
