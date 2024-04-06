using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ray";
            //string quote = "The man said,\"Hello Ray.\" \nHello on a new line. \n\t Hello on a tab. \n Use \\\\ to make a \\";
            //string fileName = @"C:\Users\Ray";  // use @ before "" so C# knows there are no escape characters in string

            //bool trueOrFalse = name.Contains("a");
            //trueOrFalse = name.EndsWith("y");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);

            //string name = "Ray";
            //name = "Jesse";
            //Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ray");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
