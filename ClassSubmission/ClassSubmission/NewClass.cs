using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    static public class NewClass
    {
        //  Above made class static and public
        //  Method public static void, take 1 parameter, perform operation and print result to console 
        public static void SubtractByFive(int num1)
        {
            int result = num1 - 5;
            Console.WriteLine($"Result for {num1} - 5 equals: {result}");
        }

    }
}
