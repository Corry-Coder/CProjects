using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Aaron", "Brett", "Steve", "Joe", "Damian", "Dwayne", "Donald" };

            Console.WriteLine("Please choose a number between 0 and 6");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[input]);


            int[] numArray = new int[] { 2, 4, 12, 20, 22, 31 };

            Console.WriteLine("Please choose a number between 0 and 5.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            bool rightInt = false;

            do
            {
                switch (input2)
                {
                    case 0:
                        Console.WriteLine(numArray[input2]);
                        rightInt = true;
                        break;

                    case 1:
                        Console.WriteLine(numArray[input2]);
                        rightInt = true;
                        break;

                    case 2:
                        Console.WriteLine(numArray[input2]);
                        rightInt = true;
                        break;

                    case 3:
                        Console.WriteLine(numArray[input2]);                        
                        rightInt = true;
                        break;

                    case 4:
                        Console.WriteLine(numArray[input2]);
                        rightInt = true;
                        break;

                    case 5:
                        Console.WriteLine(numArray[input2]);
                        rightInt = true;
                        break;

                    default:
                        Console.WriteLine("Try again. Please select a number between 0 and 5");
                        break;
                }
            }
            while (!rightInt);


            List<string> stringList = new List<string>
            {
                "Corry",
                "Thomas",
                "Becky",
                "Ricky",
                "John"
            };

            Console.WriteLine("Please choose a number between 0 and 4.");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[input3]);
            Console.ReadLine();
        }
    }
}
