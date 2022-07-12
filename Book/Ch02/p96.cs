using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-44~45
namespace Book.Ch02
{
    internal class p96
    {
        static void Mai1n(string[] args)
        {
            int num = 10;
            
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);

            int num1 = 10;
            Console.WriteLine(num1);
            num1++;
            num1++;
            Console.WriteLine(num1);
            Console.WriteLine(num1);
            num1--;
            num1--;
            Console.WriteLine(num1);
        }
    }
}
