using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Person
    {        
        //  Created Person class and gave parameters
         public string Name { get; set; }
         public int Age { get; set; }
        //  Constructor that takes no arguments
         public Person() : this("Jon Doe", 0)
         {
         }
        //  Constructor that takes both arguments
         public Person(string name, int age)
         {
             Name = name;
             Age = age;
         }
    }

    
}
