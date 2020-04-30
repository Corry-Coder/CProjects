using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
   public class Program
    {
        static void Main(string[] args)
        {
            Number Number = new Number();
            Number.Amount = 5;

            Console.WriteLine(Number.Amount);
            Console.ReadLine();
            
        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
