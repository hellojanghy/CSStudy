using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_06
    {
        static void Mai1n(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int H = int.Parse(a[0]);
            int M = int.Parse(a[1]);
            string b = Console.ReadLine();
            int P = int.Parse(b);

            int x = P / 60;
            int y = P % 60;

            int h1=0;
            int m1=0;

            if (x > 0)
            {
                h1 = H + x;
                m1 = M + y;
                if (m1 >= 60)
                {
                    m1 -= 60;
                    h1++;
                }
            }
            else
            {
                h1 = H;
                m1 = M + P;
                if (m1 >= 60)
                {
                    m1 -= 60;
                    h1++;
                    
                }
                
            }
            if (h1 >= 24)
            {
                h1 -= 24;
            }

            Console.WriteLine("{0} {1}", h1, m1);



        }
    }
}
