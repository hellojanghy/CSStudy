﻿using Ch05.Sub04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/19
 * 이름 : 장혜영
 * 내용 : 클래스 상속 실습하기 교재 p331
 * 
 * 상속(inheritance)
 *  - 기존 클래스의 속성과 기능을 그대로 자식 클래스로 확장하는 문법
 *  - 부모의 속성을 private에서 protected로 수정해서 자식 클래스에서 참조할 수 있도록 허용
 *  - 자식 클래스에서는 부모 클래스의 속성을 초기화하기 위해 생성자(bace())를 호출
 */
namespace Ch05
{
    class Parent 
    {
        private int num1;
        private int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Plus ()
        {
            return num1 + num2;
        }
    }

    class Child : Parent
    { 
        private int num3;
        private int num4;

        public Child(int num1, int num2, int num3, int num4) : base(num1, num2)
        {
            this.num3 = num3;
            this.num4 = num4;
        }

        public int Minus()
        {
            return num3 - num4;
        }
    }

    internal class _4_상속
    {
        static void Main1(string[] args)
        {
            // 상속 객체 생성
            Child c1 = new Child(1, 2, 3, 4);
            Child c2 = new Child(5, 6, 7, 8);

            Console.WriteLine("c1 Plus :" + c1.Plus());
            Console.WriteLine("c1 Plus :" + c1.Minus());
            Console.WriteLine("c2 Plus :" + c2.Plus());
            Console.WriteLine("c2 Plus :" + c2.Minus());

            // Car 상속 객체
            Sedan sedan = new Sedan("그렌져", "검정", 0, 2000);
            Truck truck = new Truck("포터", "파랑", 0, 1);

            sedan.SpeedUp(100);
            truck.SpeedUp(100);

            sedan.Show();
            truck.Show();

            // Account 상속 객체 생성
            StockAccount kb = new StockAccount("KB증권", "101-1212-1001", "홍길동", 10000, "삼성전자", 0, 0);
            kb.Deposit(1000000);
            kb.Buy(10, 50000 );
            kb.Sell(5, 52000);
            kb.Show();

        }
    }
}
