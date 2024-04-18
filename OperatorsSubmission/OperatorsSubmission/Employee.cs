using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee
    {
        // Made class public, made three properties, one int two string types
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //  Overloading " == " operator to compare Employee objects based on Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        //  Overloading " != " operator to compare Employee objects based on Id,
        //  must overload " == " and " != " as a pair
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1.Id == employee2.Id);
        }
    }

    
}
