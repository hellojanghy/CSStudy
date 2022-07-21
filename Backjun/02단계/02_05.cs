using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_05
    {
        static void Main1(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int H = int.Parse(a[0]);
            int M = int.Parse(a[1]);

            int m = M - 45;

            if (m < 0)
            {
                if (H == 0)
                {
                    H = 23;
                    m += 60;
                }
                else
                {
                    H--;
                    m += 60;
                }
            }
            
            Console.WriteLine("{0} {1}",H, m);
            
        }
    }
}
