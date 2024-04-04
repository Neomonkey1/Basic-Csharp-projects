using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
         // Takes an input from the user, multiplies it by 50, then prints the result to the console.
         Console.WriteLine("Enter a number:");
         double input1 = Convert.ToDouble(Console.ReadLine());
         double result1 = input1 * 50;
         Console.WriteLine("Result after multiplying " +input1+" by 50: " +result1);

         // Takes an input from the user, adds 25 to it, then prints the result to the console.
         Console.WriteLine("Enter a number:");
         double input2 = Convert.ToDouble(Console.ReadLine());
         double result2 = input2 + 25;
         Console.WriteLine("Result after " +input2+ " adding 25: " +result2);

         // Takes an input from the user, divides it by 12.5, then prints the result to the console.
         Console.WriteLine("Enter a number:");
         double input3 = Convert.ToDouble(Console.ReadLine());
         double result3 = input3 / 12.5;
         Console.WriteLine("Result after dividing " +input3+ " by 12.5: " +result3);

         // Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
         Console.WriteLine("Enter a number:");
         double input4 = Convert.ToDouble(Console.ReadLine());
         bool result4 = input4 > 50;
         Console.WriteLine("Is the number " +input4+ " greater than 50? " +result4);

         // Takes an input from the user, divides it by 7, then prints the remainder to the console.
         Console.WriteLine("Enter a number:");
         double input5 = Convert.ToDouble(Console.ReadLine());
         double result5 = input5 % 7;
         Console.WriteLine("Remainder after dividing " +input5+ " by 7: " +result5);
        

        Console.ReadLine();
        }
    }
}
