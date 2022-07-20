﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub01
{

    //추상클래스 : 추상메서드를 갖는 클래스
    internal abstract/*추상클래스 키워드*/ class Car
    {
        // 속성
        protected string name;
        protected string color;
        protected int speed;

        protected Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }


        // 기능
        public abstract void SpeedUp(int speed);
        public abstract void SpeedDowm(int speed);

        public virtual void Show()
        {
            Console.WriteLine("===============");
            Console.WriteLine("차량명 :" +name);
            Console.WriteLine("차량색 :" +color);
            Console.WriteLine("속도 :" +speed);
        }
    }
}
