﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/15
 * 이름: 장혜영
 * 내용: 배열 연습문제
 */
namespace Exam._02단계
{
    internal class _02_02
    {
        static void Main1(string[] args)
        {
            int[] arr = { 17, 92, 18, 33, 58, 7, 26, 42 };

            int maxNum = arr[0];

            for (int i = 0; i < 8; i++)
            {
                if (maxNum < arr[i])
                {
                    maxNum = arr[i];
                }
            }

            Console.WriteLine("배열 arr에서 가장 큰 수 :" + maxNum);

        }
    }
}
