using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters_Assignment
{
    public class Math
    {
        public int Add(int num1, int num2 = 10)
        {
            int result = num1 + num2;
            return result;
        }
    }
}
