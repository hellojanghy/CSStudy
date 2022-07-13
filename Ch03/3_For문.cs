﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/13
 * 이름 : 장혜영
 * 내용 : 반복문 for 실습하기 교재 p157
 */
namespace Ch03
{
    internal class _3_For문
    {
        static void Mai1n(string[] args)
        {
            // for문
            for(int i=1 ;i<=5 ;i++) //다섯번 반복/  i가 5보다 작으면 실행  한번 돌때마다 +1
            {
                Console.WriteLine("{0}회 반복...", i);
            }


            // 1부터 10까지 합  
            int sum = 0;

            for (int k=1 ;k<=10 ;k++) //10번반복하는데 
            {
                sum += k; //sum = sum + k;
            }
            Console.WriteLine("1부터 10까지 합 :" +sum);
            Console.WriteLine();


            // 1부터 10까지 짝수합  
            int tot = 0;

            for(int k=1 ;k<=10 ;k++)
            {
                if(k % 2 == 0)
                {
                    tot += k;
                }
                
            }
            Console.WriteLine("1부터 10까지 짝수 합 : " +tot);
            Console.WriteLine();


            // 중첩 for문
                for(int a=1; a<=3; a++)
            {
                Console.WriteLine("a :"+ a);
                for(int b=1; b<=4; b++)
                {
                    Console.WriteLine("b :"+b);
                }
            }


            // 구구단
            for(int x=2; x<=9; x++)
            {
                Console.WriteLine("{0}단",x);
                for (int y = 1; y <= 9; y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0} x {1} = {2}", x, y, z);
                }
            }


            // 별삼각형
            /*
            for (int start=1; start<=10; start++)
            {
                for(int end=1; end<= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine("\n");
            }
            */

            // 별 역삼각형
            for (int start = 10; start >= 1; start--) //앞을 바꾼 버전
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine("\n");
            }

            for (int start = 1; start <= 10; start++) //뒤를 바꾼 버전
            {
                for (int end = 10;start <= end; end--)
                {
                    Console.Write("★");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
