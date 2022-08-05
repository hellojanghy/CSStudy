using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_05
    {
        static void Mai1n(string[] args)
        {
            string n = Console.ReadLine();
            int num = int.Parse(n);
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                result.Append($"{i}\n");
            }
            Console.WriteLine(result.ToString());
        }
    }
}

