using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino1
{
    public class FraudException : Exception
    {
        // creating two constructors, one overloading another and having them implement the exact same implmentation for Exception
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
