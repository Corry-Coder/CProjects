using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                var yearOfBirth = DateTime.Now.Year - age;
                if (age == 0 || age < 0)
                {
                    throw new NegativeZeroException();
                }
            }
            catch (NegativeZeroException)
            {
                Console.WriteLine("Please don't enter a leading zero or negative numbers");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
