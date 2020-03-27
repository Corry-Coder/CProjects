using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number.");
            int multiplier1 = Convert.ToInt32(Console.ReadLine());
            int multiplier = 50;
            int product = multiplier * multiplier1;
            Console.WriteLine("The product of " + multiplier1 + " and " + multiplier + " is " + product);

            Console.WriteLine("Please choose a number.");
            int addend1 = Convert.ToInt32(Console.ReadLine());
            int addend = 25;
            int sum = addend + addend1;
            Console.WriteLine("The sum  of " + addend1 + " and " + addend + " is " + sum);

            Console.WriteLine("Please choose a number.");
            double divisor1 = Convert.ToInt32(Console.ReadLine());
            double divisor = 12.5;
            double quotient = divisor + divisor1;
            Console.WriteLine("The quotient of " + divisor1 + " and " + divisor + " is " + quotient);

            Console.WriteLine("Please choose a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = 50;
            bool isEqual = num == num2;
            Console.WriteLine(isEqual + ". The number " + num + " is not equal to " + num2);

            Console.WriteLine("Please choose a number.");
            int remainder = Convert.ToInt32(Console.ReadLine());
            int remainder2 = 7;
            int remainderTotal = remainder % remainder2;
            Console.WriteLine("The remainder of " + remainder + " divided by " + remainder2 + " is " + remainderTotal);
            Console.ReadLine();

        }
    }
}
