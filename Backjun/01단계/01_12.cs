using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/14
 * 이름 : 장혜영
 * 내용 : 백준 1단계 12번 문제
 */
namespace Backjun._01단계
{
    internal class _01_12
    {
        static void Mai1n(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();


            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            Console.WriteLine((a + b)%c);
            Console.WriteLine(((a % c) + (b % c)) % c);
            Console.WriteLine((a * b)%c);
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
