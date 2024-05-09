using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class StudentContext : DbContext
    {
        //  This class creates and sets objects from student class into a database. 
        public DbSet<Student> Students { get; set; }
    }
}
