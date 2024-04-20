using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumSubmission
{
    //  Made days of the week enum 
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  Using try and catch block here
            try
            {
                //  Asking user for input. making string variable
                Console.WriteLine("Which day of the week is it today?");
                string todayDOW = Console.ReadLine();
                
                //  Convert the user input to the enum type, added "true" to ignore cases 
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), todayDOW, true);

                
                //  Print to console current day
                Console.WriteLine($"Current day of the week: {currentDay}");

                //  If exception is thrown catch statement will print to console.
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();
        }
        
    }
}
