using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-16
namespace Book.Ch04
{
    internal class p170
    {
        static void Ma1in(string[] args)
        {
            int[] iA = { 1, 2, 3, 4, 5, 6 };

            for (int i = iA.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(iA[i]);
            }
        }
    }
}
