using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variable
            string name = "Ray";

            // using if, else if and else statements to check for several conditions
            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is Brett");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse or Brett");
            }
            Console.ReadLine();
        }
    }
}
