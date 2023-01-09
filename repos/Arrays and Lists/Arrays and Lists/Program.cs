using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList);
            Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] {5, 2, 10, 200, 5000, 600, 2300};

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            //numArray2[5] = 650; //change 600 to 650

            //Console.WriteLine(numArray[3]);
            //Console.ReadLine();

        }
    }
}
