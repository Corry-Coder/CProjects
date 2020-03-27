using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer " + '"' + "true" + '"' + " or " + '"' + "false." + '"');
            bool courseHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you like to share? Please be specific.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
