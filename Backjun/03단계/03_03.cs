using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_03
    {
        static void Main1(string[] args)
        {
            string n = Console.ReadLine();
            int num = int.Parse(n);
            int X;

            for (int i = 0; i < num; i++)
            {
                X = num - i;
                X += X;
                return;
            }
            
        }
    }
}
