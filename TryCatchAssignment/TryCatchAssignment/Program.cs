using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  Within try/catch block asking for user age, Convert to variable int
                Console.WriteLine("Please enter your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());

                //  Using IF statement to throw error message if input is 0 or negative number.
                if (userAge <= 0)
                {
                    throw new ArgumentException();
                }

                //  Using DateTime to get int for current year, then subtracting year by userAge to get year born.
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - userAge;
                //  Pring to console result
                Console.WriteLine($"You were born in {birthYear}");

            }
            //  Using catch block to display error for input of 0 or negative number
            catch (ArgumentException)
            {
                Console.WriteLine("Age cannot be zero or negative.");
            }
            //  Using catch block to display error if input is invalid
            catch (FormatException )
            {
                Console.WriteLine("Please enter a valid number for age.");
            }
            //  Using catch block to display error for all other errors
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please try again.");
            }
            






            Console.ReadLine();
        }
    }
}
