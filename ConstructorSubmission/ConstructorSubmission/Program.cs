using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Creating a const variable
            const int maxNumber = 1000;

            //  Creating a variable using var
            var myString = "Made this string using \"var\"";

            //  Print above variables to console
            Console.WriteLine($"Using const I made int {maxNumber}. {myString}");

            // Creating a DateTime object
            DateTime dateTime = new DateTime(2024, 4, 25, 11, 30, 0);

            //  Creating a TimeSpan object
            TimeSpan timeSpan = new TimeSpan(2, 15, 0);

            //  Chain two constructors together 
            DateTime dateSpan = dateTime.Add(timeSpan);

            //  Print to console above constructors
            Console.WriteLine($"The date and time is : {dateTime}, using TimeSpan to add {timeSpan} to get {dateSpan}");


            Console.ReadLine();

        }
    }
}
