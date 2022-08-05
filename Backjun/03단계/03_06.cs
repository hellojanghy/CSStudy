using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_06
    {
        static void Ma1in(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append($"{count - i}\n");
            }
            Console.WriteLine(result.ToString());
        }
    }
}

