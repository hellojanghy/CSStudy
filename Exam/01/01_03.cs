using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/14
 * 이름: 장혜영
 * 내용: 연산자 연습문제
 */
namespace Exam._01
{ 
    internal class _01_03
    {
        static void Main1(string[] args)
        {
            int x = 4;
            int y = -2;
            int z;

            z = x + y;
            Console.WriteLine("x + y = " + z);

            z = x - y;
            Console.WriteLine("x - y = " + z);

            z = x * y;
            Console.WriteLine("x * y = " + z);

            z = x / y;
            Console.WriteLine("x / y = " + z);

            z = (x + y) * (x - y);
            Console.WriteLine("(x + y) * (x - y) = " + z);

        }
    }
}
