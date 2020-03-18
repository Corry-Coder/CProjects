using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Corry\Logs\log1.txt", number.ToString());
            Console.WriteLine(number);
        }
    }
}
