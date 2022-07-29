using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/22
 *  이름 : 장혜영
 *  내용 : 클래스 다형성 연습문제
 */
namespace Exam._04
{
    class Human
    {
        public string Name;

        public Human(string name)
        {
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine(Name +"입니다.");
        }
    }

    class Worker : Human
    {
        public Worker(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("작업을 합니다.");
        }
    }

    class Developer : Human
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("개발을 합니다.");
        }
    }

    class Professor : Human
    {
        public Professor(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("연구를 합니다.");
        }
    }

    internal class _04_10
    {
        static void Main1(string[] args)
        {
            Worker    worker = new Worker("김유신");
            Developer developer = new Developer("김춘추");
            Professor professor = new Professor("장보고");

            Human[] people = { worker, developer, professor };

            foreach (Human human in people)
            {
                human.Show();
                Console.WriteLine();
            }
        }
    }
}
