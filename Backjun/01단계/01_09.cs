﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/14
 * 이름 : 장혜영
 * 내용 : 백준 1단계 9번 문제
 */
namespace Backjun._01단계
{
    internal class _01_09
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();


            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

        }
    }
}
