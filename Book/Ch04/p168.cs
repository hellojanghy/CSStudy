using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-13~14
namespace Book.Ch04
{
    internal class p168
    {
        static void Main1(string[] args)
        {
            int output = 1;

            for (int i = 1; i < 20; i++)
            {
                output *= 1;
            }
            Console.WriteLine(output);

            for (int j = '가'; j <= '힣'; j++)
            {
                Console.WriteLine((char)j);
            }
        }
    }
}
