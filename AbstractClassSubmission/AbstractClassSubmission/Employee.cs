using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee: Person, IQuittable
    {
        //  Above superclass inherit from abstract class Person, Added interface to class
        //  Using the abstract method SayName(), override SayName() so class can use method 
        public override  void SayName()
        {
            string FullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Employee Name: {FullName}");
        }

        //  Using interface method and printing to console
        public void Quit()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName} has quit their job.");
        }
    }
}
