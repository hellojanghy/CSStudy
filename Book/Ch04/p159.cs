using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-4~5
namespace Book.Ch04
{
    internal class p159
    {
        static void Main1(string[] args)
        {
            int[] iA = { 52, 273, 32, 65, 103 };

            iA[0] = 0;

            Console.WriteLine(iA[0]);
            Console.WriteLine(iA[1]);
            Console.WriteLine(iA[2]);
            Console.WriteLine(iA[3]);

            Console.WriteLine(iA.Length);
        }
    }
}
