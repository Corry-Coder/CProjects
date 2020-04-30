using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Corry";
            //string quote = "The man said, \\Hello\", Corry. \n Hello on a new line. \n \t Hello on a new tab";
            //string fileName = @"C:\Users\Corry";
            //bool trueOrFalse = name.Contains("o");
            //trueOrFalse = name.EndsWith("c");

            //int length = name.Length;
            //name = name.ToLower();

            //Console.WriteLine(length);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Corry");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
