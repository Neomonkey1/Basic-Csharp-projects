using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Making three string variables
            string part1 = "I will concatenate";
            string part2 = " three strings together";
            string part3 = " into one!";

            //  I will Concatenate the string variables together here
            Console.WriteLine(part1 + part2 + part3);

            // I will convert string variable part3 into uppercase
            part3 = part3.ToUpper();
            Console.WriteLine(part3);

            // Making a variable for StringBuilder
            StringBuilder paragraph = new StringBuilder();

            // Adding three sentence to paragraph with Append. Using escape characters to make it look nicer.
            paragraph.Append("This is my first sentence. \n");
            paragraph.Append("This will be my second sentence. \n");
            paragraph.Append("This will be my last sentence. \n");

            // Converting StringBuilder to string to print to console.
            string paragraphSB = paragraph.ToString();
            Console.WriteLine(paragraphSB);



            Console.ReadLine();
        }
    }
}
