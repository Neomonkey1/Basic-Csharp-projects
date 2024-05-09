using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  using to created connention to database
            using (var context = new StudentContext())
            {
                //  Calling student class to create student, add student object to database, save changes to database.
                var student = new Student() { Id = 1, FirstName = "John", LastName = "Smith", Age = 21 };
                context.Students.Add(student);
                context.SaveChanges();

                //  Made var to retrieve details from database, using foreach statement to display details from var to console
                var students = context.Students;
                foreach (var s in students)
                {
                    Console.WriteLine($"Student Id: {s.Id}, First name: {s.FirstName}, Last name: {s.LastName}, Age: {s.Age}");
                }
            }

            Console.ReadLine();
        }
    }
}
