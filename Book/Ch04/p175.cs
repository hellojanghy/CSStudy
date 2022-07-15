using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-20
namespace Book.Ch04
{
    internal class p175
    {
        static void Mai1n(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                    Console.Write('\n');
                }
            }
        }
    }
}
