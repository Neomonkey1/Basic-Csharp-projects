using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSubmission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Using bool logic with While loop to continue to print i then increment by 1 while True
            //  once met will go to else statement where condition will be set to false and end loop.
            bool condition = true;
            int i = 0;
            
            while (condition)
            {
                if (i < 6)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else
                {
                    condition = false;
                }
                
            }


            //  Asking user to guess a day input will be set to string variable and compared to bool variable. 
            Console.WriteLine("Guess the best day!");
            string guessDay = Console.ReadLine();
            bool isGuessed = guessDay == "Sunday";

            //  Using do while loop to go through all guesses from user till bool variable is true ( Sunday ) 
            //  Using switch statement to go through all guesses and using default to catch if user misspells or forgets to capitalize.
            do
            {
                switch (guessDay)
                {
                    case "Monday":
                        Console.WriteLine("Monday is not the best day. Try again.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                    case "Tuesday":
                        Console.WriteLine("Tuesday is not the best day. Try again.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("Wednesday is not the best day. Try again.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                    case "Thursday":
                        Console.WriteLine("Thursday is not the best day. Try again.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                    case "Friday":
                        Console.WriteLine("Friday is not the best day. Try again.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                    case "Saturday":
                        Console.WriteLine("Saturday is not the best day. Try again.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                    case "Sunday":
                        Console.WriteLine("Sunday is the best day!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Please check your spelling and Capitalize.");
                        Console.WriteLine("Guess the best day!");
                        guessDay = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);




            Console.ReadLine();
        }
    }
}
