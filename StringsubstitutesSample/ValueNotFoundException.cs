using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsubstitutesSample
{
    public class ValueNotFoundException : Exception
    {
        public ValueNotFoundException()
        {
        }

        public ValueNotFoundException(string message)
            : base(message)
        {
        }

        public ValueNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
