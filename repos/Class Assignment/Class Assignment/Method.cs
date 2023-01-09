using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Method
    {
        public void twoInts(int i) //naming method twoInts with parameter i
        {
            int divideBy2 = i / 2; //
            Console.WriteLine(divideBy2); //divide by 2
        }
        public void outParameter(out int i, out int j) //name method outParameters
        {
            i = 1; //can have multiple values because out int
            i += 2;

            j = 3;
            j += 4;
        }
        public int overload(int a, int b) //naming method overload
        {
            int sum = a + b;
            return sum;
        }
        public int overload(int a, int b, int c) //overloading method - can change variables
        {
            int sum = a + b + c;
            return sum;
        }
    }
}
