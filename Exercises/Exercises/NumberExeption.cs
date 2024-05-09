using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class NumberExeption : Exception
    {
        public NumberExeption() : base() { }
        public NumberExeption(string message) : base(message) 
        {
            throw new NumberExeption("The value is not a number");
        }
        public NumberExeption(string message, Exception innerException) : base(message, innerException) { }
    }
}
