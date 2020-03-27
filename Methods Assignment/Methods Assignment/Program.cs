using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
{
    class Program
    {
        public static int data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to do math.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            var mathObject = new Math();
            var result = mathObject.Add(userInput, 6);
            result = mathObject.Subtract(result, 10);
            result = mathObject.Multiply(result, 3);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
