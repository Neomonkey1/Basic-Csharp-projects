using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Made a List using class Employee
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Alice", LastName = "Smith"},
                new Employee { Id = 2, FirstName = "Bob", LastName = "Johnson"},
                new Employee { Id = 3, FirstName = "Joe", LastName = "Doe"},
                new Employee { Id = 4, FirstName = "Emily", LastName = "Brown"},
                new Employee { Id = 5, FirstName = "Joe", LastName = "Williams"},
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Davis"},
                new Employee { Id = 7, FirstName = "Mike", LastName = "Wilson"},
                new Employee { Id = 8, FirstName = "Joe", LastName = "Anderson"},
                new Employee { Id = 9, FirstName = "Laura", LastName = "Martinez"},
                new Employee { Id = 10, FirstName = "David", LastName = "Garcia"},
            };

            //  Making new List from List employees.
            //  Using foreach loop through List employees,
            //  using IF to fill List with each employee with the first name Joe
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if ( employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            //  Using foreach loop to print each employee from new List on console
            Console.WriteLine("List of employees with the first name: \"Joe\"");
            foreach (Employee joe in joeList)
            {
                Console.WriteLine($"ID Number: {joe.Id} Full Name: {joe.FirstName} {joe.LastName}");
            }

            //  Making new List from List employees using Lambda expression where all employee with name Joe are added to List
            List<Employee> joeList1A = employees.Where(employee => employee.FirstName == "Joe").ToList();
            
            //  Using foreach loop to print each employee from new List on console
            Console.WriteLine("\nList of employees with the first name: \"Joe\"");
            foreach (Employee joe1 in joeList1A)
            {
                Console.WriteLine($"ID Number: {joe1.Id} Full Name: {joe1.FirstName} {joe1.LastName}");
            }

            //  Making new List from List employees using Lambda expression
            //  where all employees with ID 5 and higher are added to List
            List<Employee> idList = employees.Where(employee => employee.Id >= 5).ToList();

            //  Using foreach loop to print each employee from new List on console
            Console.WriteLine("\nList of employees with ID numbers 5 and higher: ");
            foreach (Employee idEmp in idList)
            {
                Console.WriteLine($"ID Number: {idEmp.Id} Full Name: {idEmp.FirstName} {idEmp.LastName}");
            }




            Console.ReadLine();
        }
    }
}
