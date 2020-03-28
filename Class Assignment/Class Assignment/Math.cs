using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Math
    {
        public int Operations(string data)
        {
            string input = data;
            string input2 = "100";
            int sum = int.Parse(input) + int.Parse(input2);
            return Convert.ToInt32(sum);
        }

        public decimal Operations(decimal product)
        {
            decimal answer = product * 100;
            return Convert.ToInt32(answer);
        }

        public int Operations(int difference)
        {           
            int number = difference - 20;
            return number;
        }
    }
}
