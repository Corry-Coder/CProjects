using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
    }
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
