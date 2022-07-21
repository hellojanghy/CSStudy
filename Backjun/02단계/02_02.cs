using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_02
    {
        static void Main1(string[] args)
        {
            string a = Console.ReadLine();
            int aa = int.Parse(a);

            if (aa <= 100 && aa >= 90)
                Console.WriteLine("A");
            else if (aa < 90 && aa >= 80)
                Console.WriteLine("B");
            else if (aa < 80 && aa >= 70)
                Console.WriteLine("C");
            else if (aa < 70 && aa >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");

        }
    }
}
