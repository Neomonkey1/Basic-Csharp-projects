using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person
    {
        //  Above made public abstract class
        //  Making two properties object
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //  Making abstract method that all inherit class can use.
        public abstract void SayName();
                 
        
    }
}
