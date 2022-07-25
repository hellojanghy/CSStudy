using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_01
    {
        static void Main1(string[] args)
        {
            string n = Console.ReadLine();
            int num = int.Parse(n);
            int X;

            if (num < 0 || num > 9)
            {
                Console.WriteLine("1에서 9 사이 값을 입력해 주세요.");
            }

            for (int i = 1; i <= 9; i++)
            {
                X = num * i;
                Console.WriteLine("{0} * {1} = {2}" ,num, i, X);

            }
        }
    }
}

