using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptions
{
    public class NegativeZeroException : Exception
    {
        public NegativeZeroException()
            : base() { }
        public NegativeZeroException(string message)
            : base(message) { }
            
    }
}
