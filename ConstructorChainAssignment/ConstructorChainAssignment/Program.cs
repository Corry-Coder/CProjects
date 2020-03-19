using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Corry");
            person.SayName();
            Console.ReadLine();
             
        }
    }
}
