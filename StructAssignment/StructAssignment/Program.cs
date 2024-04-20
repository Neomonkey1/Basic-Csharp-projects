using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Created object 
            Number num = new Number();

            //  Give the property Amount a value
            num.Amount = 25.50m;

            //  Printing to console the object value
            Console.WriteLine($"Struct number entered is {num.Amount}");


            Console.ReadLine();
        }
        
    }
}
