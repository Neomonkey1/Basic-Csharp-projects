using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            // This will print out The Tech Academy. on one line than after the '\n' Student Daily Report will print on the next line. 
            Console.WriteLine("The Tech Academy. \nStudent Daily Report.");
            
            // This line will ask for the users Name.
            Console.WriteLine("What is your name?");
            // Saving reply as string variable
            string userName = Console.ReadLine();
            
            // Using value from userName in this line will ask which course user is on.
            Console.WriteLine(userName + " What course are you on?");
            // Saving reply as string variable
            string userCourse = Console.ReadLine();
            
            // This line will ask what page the user is on while using the value of userCourse
            Console.WriteLine("What page in the " + userCourse + " course are you currently on?");
            // Saving reply as string variable
            string currentPage = Console.ReadLine();
            // Converting string variable to int variable here
            int coursePage = Convert.ToInt32(currentPage);
            
            // This line is asking if they need help with anything. also using escape characters 
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            // Saving reply as string variable
            string userHelp = Console.ReadLine();
            // Converting string to boolean
            bool needHelp = Convert.ToBoolean(userHelp);
            
            // This line is asking the user so share any positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            // Saving reply as string variable
            string userExp = Console.ReadLine();
            
            // This line is asking the user for any other feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            // Saving reply as string variable
            string userFeedback = Console.ReadLine();
           
            // This line is asking the user how many hours they studied
            Console.WriteLine("How many hours did you study today?");
            // Saving reply as string variable
            string userHours = Console.ReadLine();
            // Converting string variable to int variable
            int studyHours = Convert.ToInt32(userHours);
            
            // This line is thanking the user (using value from userName) for answering the questions and will end program.
            Console.WriteLine("Thank you " + userName + " for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
