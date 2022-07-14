using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/14
 * 이름: 장혜영
 * 내용: 증가, 감소 연산자 연습문제
 */
namespace Exam._01
{
    internal class _01_04
    {
        static void Main1(string[] args)
        {
            int num = 1;
            int result;

            result = num++; 
            Console.WriteLine("result :"+ result);

            result = ++num;
            Console.WriteLine("result :" + result);

            result = num--;
            Console.WriteLine("result :" + result);

            result = --num;
            Console.WriteLine("result :" + result);

        }
    }
}
