using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainAssignment
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public Person(string firstName) : this(firstName, "Success")
        {
        }
        public Person(string firstName,  string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
