using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentWeight = 50;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");

            int initialWeight = Convert.ToInt32(Console.ReadLine());

            if (initialWeight > currentWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int totalDimensions = packageWidth + packageHeight + packageLength;
                decimal shippingQuote = packageWidth * packageLength * packageHeight * initialWeight / 100;
          
            if (totalDimensions > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
            else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + shippingQuote);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
