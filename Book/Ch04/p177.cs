﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-22
namespace Book.Ch04
{
    internal class p177
    {
        static void Mai1n(string[] args)
        {
            while (true)
            {

            
            Console.WriteLine("숫자를 입력해주세요(짝수를 입력하면 종료):");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                break;
            }}
        }
    }
}
