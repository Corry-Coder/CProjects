using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Opperator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            employee1.Id = 22;
            employee.Id = 6;
            Console.WriteLine(employee1 == employee);
            Console.ReadLine();
        }
    }
}
