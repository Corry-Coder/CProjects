using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool myNumber = number == 22;

            do
            {
                switch (number)
                {
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                        Console.WriteLine("Guess my favorite number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        Console.WriteLine("Congratulations! You guessed my favorite number");
                        myNumber = true;
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. Try again.");
                        Console.WriteLine("Guess my favorite number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You guessed incorrectly. Try again");
                        Console.WriteLine("Guess my favorite number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!myNumber);
            Console.ReadLine();
        }
    }
}
