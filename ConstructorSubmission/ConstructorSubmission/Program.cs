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

            //  Created Person object 1 and this Person object 2 below.
            //  Person object 1 uses no parameters constructor so uses default value
            //  Person object 2 uses constructor that takes name and age
            Person person1 = new Person();

            Person person2 = new Person("Jane Smith", 20);

            //  Print to console both Person object 1 and Person object 2
            Console.WriteLine($"Person object 1: {person1.Name} {person1.Age} and Person object 2: {person2.Name} {person2.Age}");
            
            
            
            
            Console.ReadLine();

            

        }
    }
}
