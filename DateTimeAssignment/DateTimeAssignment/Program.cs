using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please choose a number.");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In exactly " + answer + " hours it will be " + DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}
