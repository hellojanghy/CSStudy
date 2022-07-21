using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_03
    {
        static void Main1(string[] args)
        {
            string a = Console.ReadLine();
            int Num1 = int.Parse(a);

            if (Num1 % 4 == 0 && Num1 % 100 != 0 )
                Console.WriteLine(1);
            else if (Num1 % 400 == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
