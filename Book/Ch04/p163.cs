using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-10
namespace Book.Ch04
{
    internal class p163
    {
        static void Main1(string[] args)
        {
            int i = 0;
            int[] iA = { 52, 273, 32, 65, 103 };

            while (i < iA.Length)
            {
                Console.WriteLine(i + "번쨰 출력:" + iA[i]);

                i++;
            }
        }
    }
}
