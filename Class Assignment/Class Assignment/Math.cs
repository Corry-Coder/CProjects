using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Math
    {
        public string Operations(string data)
        {
            string sum = data + "Hello";
            return sum;
        }

        public decimal Operations(decimal product)
        {
            decimal answer = product * 100;
            return answer;
        }

        public int Operations(int difference)
        {           
            int number = difference - 20;
            return number;
        }
    }
}
