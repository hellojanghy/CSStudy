﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-32
namespace Book.Ch04
{
    internal class p187
    {
        static void Main1(string[] args)
        {
            int x = 1;
            while (x < 50)

            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");

                else if (x % 3 == 1)
                    Console.WriteLine("_^@");

                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;

            }
        }
    }
}
