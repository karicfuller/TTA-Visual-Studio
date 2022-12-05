using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Methods
    {
        public int Addition(int i)
        {
            int sum = i + 1; //will add 1 to int
            return (sum);
        }
        public int Addition(decimal j) //using decimal
        {
            int theDecimal = Convert.ToInt32(j) + 1; //converting decimal to int
            return (theDecimal);
        }
        public int Addition(string x)
        {
            int toInt = Convert.ToInt32(x) - 1; //changing string to int
            return toInt;
        }
    }
}
