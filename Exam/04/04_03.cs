using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/22
 *  이름 : 장혜영
 *  내용 : Getter, Setter 연습문제
 */
namespace Exam._04
{
    class Emloyee
    {
        public string Name { get; set; } = "홍길동";
        public string Position { get; set; } = "사원";

        public void Show()
        {
            Console.WriteLine("======================");
            Console.WriteLine("이름 :" + Name);
            Console.WriteLine("직급 :" + Position);
            Console.WriteLine("----------------------");
        }
    }
    internal class _04_03
    {
        static void Main1(string[] args)
        {
            Emloyee em1 = new Emloyee();
            em1.Show();

            Emloyee em2 = new Emloyee();

            em2.Name = "김유신";
            em2.Position = "대리";
            em2.Show();

            Emloyee em3 = new Emloyee() {Name="김춘추", Position="과장"};
            em3.Show();
        }
    }
}
