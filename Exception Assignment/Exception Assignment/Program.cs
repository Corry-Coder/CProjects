using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> randomNumbers = new List<int>();
                randomNumbers.Add(2);
                randomNumbers.Add(22);
                randomNumbers.Add(10);
                randomNumbers.Add(3);
                randomNumbers.Add(5);

                Console.WriteLine("Please choose a number to divide by.");
                int answer = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < randomNumbers.Count; i++)
                {
                    int result = randomNumbers[i] / answer;
                    Console.WriteLine("The result of the numbers divided by " + answer + " is " + result);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a number.");
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued with execution.");
            }
            
            Console.ReadLine();
        }
    }
}
