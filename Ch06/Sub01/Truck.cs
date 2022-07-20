﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub01
{
    internal class Truck : Car
    {
        private int capacity;

        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public override void SpeedDowm(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Sedan SpeedDown...");
        }

        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Sedan SpeedUp...");
        }
        public override void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 :" + name);
            Console.WriteLine("차량색 :" + color);
            Console.WriteLine("속도 :" + speed);
            Console.WriteLine("적재용량 :" + capacity);
            Console.WriteLine("-----------------");
        }
    }
}
