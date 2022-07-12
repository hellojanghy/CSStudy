using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022 07월 12일
 * 이름 : 장혜영
 * 내용 : C# 기본 입출력 실습하기 교재 p104
 */
namespace Ch02
{
    internal class _4기본입출력
    {
        static void Main(string[] args)
        {
            // 이름 입력
            Console.Write("이름 입력 :");  //출력
            string name = Console.ReadLine();  //입력 (서로 반대)

            // 나이 입력
            Console.Write("나이 입력 :"); //Write는 그대로 있고 WriteLine는 커서가 밑으로 감
            string age = Console.ReadLine();

            //주소 입력
            Console.Write("주소 입력 :");  
            string addr = Console.ReadLine();


            Console.WriteLine("====================");
            Console.WriteLine("이름:"+name);
            Console.WriteLine("나이:" + age);
            Console.WriteLine("주소:" + addr);
        }

    }
}
