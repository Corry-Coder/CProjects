using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleMethods
{
    public class Method
    {
        public int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }

        public int Multiply(int a, int b, int c)
        {
            int product = a * b * c;
            return product;
        }
    }
}
