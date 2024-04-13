using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_2
{
    public class MathOperation
    {
        //  Making public method for adding
        public int AddNumbers (int num)
        {
            return num + 25;
        }

        //  Making public method for multiply decimal number then converting to int
        public int MultiplyNumbers (decimal num)
        {
            decimal results = num * 4m;
            return Convert.ToInt32(results);
        }

        //  Making public method for taking in a string, converting it to int then dividing it.
        public int DivideString (string someInput)
        {
            int num = Convert.ToInt32(someInput);
            return  num / 3;
            
        }
            
    }
}
