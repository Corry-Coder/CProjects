using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonContext())
            {
                db.Persons.Add(new Person { FullName = "Corry Woodard" });
                db.SaveChanges();

                foreach (var person in db.Persons)
                {
                    Console.WriteLine(person.FullName);
                    Console.ReadLine();
                }
            }
        }
    }
}
