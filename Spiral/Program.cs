using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[10];
            for (int i = 0; i < testArr.Length; i++) {
                testArr[i] = 2 * i;
            }
            Console.WriteLine(testArr[7]);

            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine(testArr[x]);
            Console.ReadLine();
        }
    }
}
