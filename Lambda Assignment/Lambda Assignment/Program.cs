using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {            
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.firstName = "Joe";
            employee1.lastName = "Proctor";
            employee1.Id = 1;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.firstName = "Joe";
            employee2.lastName = "Rogan";
            employee2.Id = 2;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.firstName = "Michelle";
            employee3.lastName = "Jordan";
            employee3.Id = 3;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.firstName = "Corry";
            employee4.lastName = "Woordard";
            employee4.Id = 4;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.firstName = "Kaleb";
            employee5.lastName = "Bryant";
            employee5.Id = 5;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.firstName = "Alex";
            employee6.lastName = "Iverson";
            employee6.Id = 6;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.firstName = "Bruce";
            employee7.lastName = "Favre";
            employee7.Id = 7;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.firstName = "Angel";
            employee8.lastName = "Rodgers";
            employee8.Id = 8;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.firstName = "Shawn";
            employee9.lastName = "Michaels";
            employee9.Id = 9;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.firstName = "Bernie";
            employee10.lastName = "Bonds";
            employee10.Id = 10;
            employees.Add(employee10);

            List<Employee> joeList = new List<Employee>();


            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    Employee joeList1 = new Employee();
                    joeList1.firstName = "Joe";
                    joeList.Add(joeList1);
                    Console.WriteLine(joeList);
                    Console.ReadLine();
                }

            }

            List<Employee> newList = employees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName);
                Console.ReadLine();
            }
        }
        
        
    }
}
