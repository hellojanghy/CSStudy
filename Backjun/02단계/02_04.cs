using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_04
    {
        static void Main1(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            int X = int.Parse(x);
            int Y = int.Parse(y);

            //if (X == 0 || Y == 0 || -1000 >= Y || Y >= 1000 || -1000 >= X || X >= 1000)
           // {
           //     return;
           // }

            if (X > 0 && Y > 0)
            {
                Console.WriteLine(1);
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine(2);
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
            }
            




        }
    }
}
