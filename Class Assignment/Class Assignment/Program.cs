using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            string data = Console.ReadLine();
            Math mathClass = new Math();
            string sum = mathClass.Operations(data);
            Console.WriteLine(sum);


            Console.WriteLine("Please enter a decimal number");
            decimal product = Convert.ToDecimal(Console.ReadLine());
            decimal answer = mathClass.Operations(product);
            Console.WriteLine(answer);


            Console.WriteLine("Please enter a number");
            int difference = Convert.ToInt32(Console.ReadLine());
            int number = mathClass.Operations(difference);
            Console.WriteLine(number);
            Console.ReadLine();


        }
        
    }
    
}
