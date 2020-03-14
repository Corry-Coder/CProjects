using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>
            {
                "Corry",
                "Jerry",
                "Bill"
            };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>
            {
                2,
                4,
                22
            };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            
        }
    }
}
