﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6-20
namespace Book.Ch06
{
    internal class p287
    {
         class Sample
        {
            public static int value;

            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");


            }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번쨰 위치");
        }
    }
}
