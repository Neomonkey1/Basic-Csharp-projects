using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_3
{
    //  Made class public
    public class MathOperation
    {

        //  Made method public, value for num1 is from user input,
        //  value for num2 is either user input or set value 1
        public int AddNumbers(int num1, int num2 = 1)
        {
            //  return result as int
            return num1 + num2;
        }
    }
}
