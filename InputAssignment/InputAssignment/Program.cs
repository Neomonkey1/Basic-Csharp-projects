using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{  //  Above add "using System.IO"
    class Program
    {
        static void Main(string[] args)
        {
            //  Asking user input, saving input to string variable
            Console.WriteLine("Please pick a number.");
            string numText = Console.ReadLine();

            //  Write user input to a .txt file using "using" statement
            using (StreamWriter file = new StreamWriter(@"C:\Users\neomo\OneDrive\Documents\GitHub\Basic-C--projects\InputAssignment\Log\log.txt", true))
            {
                file.WriteLine(numText);
            }

            //  Using "using" statement to read .txt file, making string variable of .txt file and printing to console.
            using (StreamReader file1 = new StreamReader(@"C:\Users\neomo\OneDrive\Documents\GitHub\Basic-C--projects\InputAssignment\Log\log.txt"))
            {
                string numFromFile = file1.ReadLine();
                Console.WriteLine($"The number you picked is logged in {numFromFile}");
            }

            


            Console.ReadLine();
        }
    }
}
