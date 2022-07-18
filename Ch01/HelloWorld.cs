using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/12
 * 이름 : 장혜영
 * 내용 : C# 개발환경 설정, Hello World 출력 교재 p44
 */
namespace Ch01
{
    internal class HelloWorld
    {

        static void Main1(string[] args)
        {
            //기본 출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#!");

            //서식 출력 
            Console.Write("Hello\t"); //tab 띄어쓰기 
            Console.Write("Korea\n"); //new line 밑으로 여백 생김

            //포맷 출력
            Console.WriteLine("{0}, {1}","Hello","Busan");
        }
    }
}
