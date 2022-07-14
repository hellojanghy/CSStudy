using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/14
 * 이름 : 장혜영
 * 내용 : 백준 1단계 13번 문제
 */
namespace Backjun._01단계
{
    internal class _01_13
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            Console.WriteLine();
            string str2 = Console.ReadLine();

            //string str2[0];
            int r1 = int.Parse(str1); //문자에서 숫자로 변환
            int r2 = int.Parse(str2);

            int[] int1 = new int[r2];

            int n1 = int1[0];
            Console.WriteLine(r1 * n1);
            //Console.WriteLine(r1*r2);

        }
    }
}
