using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/22
 *  이름 : 장혜영
 *  내용 : 분할 클래스 연습문제
 */
namespace Exam._04
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1...");
        }
        public void Method2()
        {
            Console.WriteLine("Method2...");
        }
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3...");
        }
        public void Method4()
        {
            Console.WriteLine("Method4...");
        }
    }

    internal class _04_02
    {
        static void Mai1n(string[] args)
        {
            MyClass my = new MyClass();
            my.Method1();
            my.Method2();
            my.Method3();
            my.Method4();
        }
    }
}
