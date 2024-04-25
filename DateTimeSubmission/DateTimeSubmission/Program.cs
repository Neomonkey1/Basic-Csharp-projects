using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Print to console current time
            Console.WriteLine($"The current time is: {DateTime.Now}");

            //  Asking for user input, convert to double variable
            Console.WriteLine("Please enter a number.");
            double userNum = Convert.ToDouble(Console.ReadLine());

            //  Made variable "futureTime" using DateTime.Now for current time and
            //  using AddHours with user input to add hours to current time to get "futureTime" 
            DateTime futureTime = DateTime.Now.AddHours(userNum);

            //  Print to console user input and futureTime
            Console.WriteLine($"The time in {userNum} hours will be {futureTime}");





            Console.ReadLine();
        }
    }
}
