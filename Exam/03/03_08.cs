using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/21
 * 이름 : 장혜영
 * 내용 : 다형성 연습문제
 */
namespace Exam._03
{
    class Prodect
    {
        protected string category;
        protected int price;

        public Prodect(string category, int price)
        {
            this.category = category;
            this.price = price;
        }
        public virtual void Show() { }
    }

    class Television : Prodect
    {
        public Television(string category, int price) : base(category, price)
        { 
        }

        public override void Show()
            { 
            Console.WriteLine("제품분류: " + category);
            Console.WriteLine("제품가격: " + price);
            }
    }

    class Computer : Prodect
    {
        public Computer(string category, int price) : base(category, price)
        {
        }

        public override void Show()
        {
            Console.WriteLine("제품분류: " + category);
            Console.WriteLine("제품가격: " + price);
        }
    }

    internal class _03_08
    {
        static void Main1(string[] args)
        {
            Prodect p1 = new Television("TV", 100);
            Prodect p2 = new Computer("컴퓨터", 150);

            p1.Show();
            p2.Show();
        }
    }
}
