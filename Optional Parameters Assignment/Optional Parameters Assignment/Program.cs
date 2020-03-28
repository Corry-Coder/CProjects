using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathClass = new Math();
            Console.WriteLine("Please enter two numbers one at a time. However, you dont have to enter a second number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number if you wish");

            int num2;
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                int result = mathClass.Add(num1, num2);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else
            {
                int result = mathClass.Add(num1);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
