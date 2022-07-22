﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/21
 * 이름 : 장혜영
 * 내용 : 클래스 연습문제
 */

namespace Exam._03
{
    class Car
    {
        private string company;
        private string name;
        private int price;

        public Car(string company, string name, int price)
        {
            this.company = company;
            this.name = name;
            this.price = price;
        }

        private void Drive()
        {
            Console.WriteLine(name + "운행 중...");
        }

        public void Show()
        {
            Drive();
            Console.WriteLine("제조사 :" + company);
            Console.WriteLine("차량명 :" + name);
            Console.WriteLine("가격 :" + price);
            Console.WriteLine();
        }
    }


    internal class _03_03
    {
        static void Mai1n(string[] args)
        {
            Car sonata;
            Car bmw;

            sonata  = new ("현대", "소나타", 3000);
            bmw     = new ("bmw", "520d", 5000);

            sonata.Show();
            bmw.Show();
        }   
    }
}
