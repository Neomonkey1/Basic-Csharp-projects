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
                //  Using enum to parse user input 
                DaysOfWeek currentDay;

                //  Using switch statements to go through all possible days, throw exception if invalid day is entered,
                //  using ToLower() to help minimize user error.
                switch (todayDOW.ToLower())
                {
                    case "monday":
                        currentDay = DaysOfWeek.Monday;
                        break;
                    case "tuesday":
                        currentDay = DaysOfWeek.Tuesday;
                        break;
                    case "wednesday":
                        currentDay = DaysOfWeek.Wednesday;
                        break;
                    case "thursday":
                        currentDay = DaysOfWeek.Thursday;
                        break;
                    case "friday":
                        currentDay = DaysOfWeek.Friday;
                        break;
                    case "saturday":
                        currentDay = DaysOfWeek.Saturday;
                        break;
                    case "sunday":
                        currentDay = DaysOfWeek.Sunday;
                        break;
                    default:
                        throw new ArgumentException("Invalid day of the week entered.");

                }
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
