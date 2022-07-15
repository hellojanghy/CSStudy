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
        static void Main1(string[] args)
        {
            /*
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int r1 = int.Parse(str1); 
            int r2 = int.Parse(str2);

            Console.WriteLine(r1 * (r2%10));
            Console.WriteLine(r1 * ((r2/10) % 10));
            Console.WriteLine(r1 * ((r2/100) % 10));
            Console.WriteLine(r1 * r2);
            */

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(int.Parse(str1) * (int)Char.GetNumericValue(str2[2]));
            Console.WriteLine(int.Parse(str1) * (int)Char.GetNumericValue(str2[1]));
            Console.WriteLine(int.Parse(str1) * (int)Char.GetNumericValue(str2[0]));
            Console.WriteLine(int.Parse(str1) * int.Parse(str2));
        }
    }
}
