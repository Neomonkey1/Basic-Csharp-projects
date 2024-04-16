using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    public class Person
    {
        //  Above made class public
        //  Making two properties for class, both string types
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //  Method public void
        public void SayName()
        {
            //  Method takes in variables from object and concatenate and print to console
            string FullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Name: {FullName}");
        }
    }
}
