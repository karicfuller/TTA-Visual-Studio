using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class ZeroException : Exception
    {
        public ZeroException()
        {
            Console.WriteLine("Please use a number larger than zero.");
        }
    }
}
