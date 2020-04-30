using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    public abstract class Person
    {   
        public virtual void SayName() { }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
