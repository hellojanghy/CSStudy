﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub01
{
    internal class Car
    {
        //속성(필드)
        public string name;
        public string color;
        public int speed;

        //기능(메서드)
        public void SpeedUp(int speed) 
        {
            this.speed += speed; //this 여기 스피드

        }

        public void SpeedDown(int speed) 
        {
            this.speed -= speed;
        }

        public void Show() 
        {
            Console.WriteLine("==================");
            Console.WriteLine("차량명: "+name);
            Console.WriteLine("차량색: "+color);
            Console.WriteLine("현재속도: "+speed);
            Console.WriteLine("------------------");
        }


    }
}
