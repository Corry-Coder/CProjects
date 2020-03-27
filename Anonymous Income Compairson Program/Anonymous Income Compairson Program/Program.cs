using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Compairson_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Compairson Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of person 1:");
            double annualSalary = hourlyRate * hoursWorked * 52;
            Console.WriteLine(annualSalary);
            Console.WriteLine("Annual salary of person 2:");
            double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine(annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isEqual = annualSalary == annualSalary2;
            Console.WriteLine(isEqual);
            Console.ReadLine();

        }
    }
}
