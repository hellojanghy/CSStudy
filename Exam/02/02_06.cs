﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/15
 * 이름: 장혜영
 * 내용: 메서드 연습문제
 */
namespace Exam._02단계
{
    internal class _02_06
    {
       public static void intro() //리턴 키워드 없음
        {
            Console.WriteLine("******* START *******");
            Console.WriteLine("두개의 정수를 입력");
        }

        public static int input(char name)
        {
            Console.Write("변수" + name + " 값 입력 : ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        public static void result(int val)
        {
            Console.WriteLine("덧셈 결과 :" + val);
            Console.WriteLine("******* ENd *******");
        }

        public static int add(int x, int y)
        {
            return x + y;
        }

        static void Mai1n(string[] args)
        {
            intro();

            int a = input('a');
            int b = input('b');

            int output = add(a, b);
                result(output);

        }
        
    }
}
