using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_01
    {
        static void Main1(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int num1 = int.Parse(a[0]);
            int num2 = int.Parse(a[1]);

            if (num1 > num2)
                Console.WriteLine(">");

            else if (num1 < num2) 
                Console.WriteLine("<");

            else if (num1 == num2) 
                Console.WriteLine("==");
        }
    }
}
