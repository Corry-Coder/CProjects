using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleMethods
{
    public class Program
    {
        static void Main(string[] args)
        {   //Method Overloading//
            Method overLoad = new Method();
            int product = overLoad.Multiply(2, 4);
            Console.WriteLine("The product of two integers is: {0}", product);
            int product2 = overLoad.Multiply(2, 4, 6);
            Console.WriteLine("The product of three integers is: {0}", product2);
            Console.ReadLine();


            //Void method that outputs an integer//
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            Math mathClass = new Math();
            mathClass.Divide(num);


            int c;
            Multiply(out c);
            Console.WriteLine("The multiplication of C by itself is: {0}", c);
            Console.ReadLine();
        }
        //Method with output parameters//
        private static void Multiply(out int c)
        {
            c = 20;
            c *= c;
        }  
    }
}
