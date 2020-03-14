using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string dayString = Console.ReadLine();
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayString);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid day of the week.");
                Console.ReadLine();
            }
            

        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}
