using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Making a int List
            List<int> numList = new List<int>() {10, 15, 30, 44, 100, 108 };

            
            //  Put code in TRY CATCH block to catch different exceptions
            try
            {

                //  Asking for user input and converting input to int variable
                Console.WriteLine("Please enter a number.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                //  Using FOREACH to iterate through the int List and divide it by the userNum and printing result to console
                foreach (int i in numList)
                {
                    int numResults = i / userNum;
                    Console.WriteLine($"{i} divide by {userNum} equals {numResults}");
                }
            }
            //  This CATCH block will throw exception if user divides by zero, print message to console
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error, you can't divide by zero.");
            }
            //  This CATCH block will throw exception if user inputs the wrong format, print message to console
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter only whole numbers");
            }
            //  This CATCH block will throw any other exceptions from user input not catched in the first two. print message to console
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }



            Console.ReadLine();
        }
    }
}
