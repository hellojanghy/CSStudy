using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_02
    {
        static void Main1(string[] args)
        {
            string n = Console.ReadLine();
            int num = int.Parse(n);

            for (int i = 0; i < num; i++)
            {
            string[] arr = Console.ReadLine().Split(' ');
            int A = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);

            Console.WriteLine(A + B);
            }
        }
    }
}
