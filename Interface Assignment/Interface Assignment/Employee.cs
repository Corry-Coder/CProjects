using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    public class Employee : IQuittable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual void Quit()
        {
            firstName = "Sample";
            lastName = "Student";
            Console.WriteLine(firstName + lastName + " quits");
;
        }
    }
}
