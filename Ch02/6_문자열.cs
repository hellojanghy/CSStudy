using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/13
 * 이름 : 장혜영
 * 내용 : 문자열 실습하기 교재 p112
 */
namespace Ch02
{
    internal class _6문자열
    {
        static void Main1(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            //문자열 길이
            Console.WriteLine("길이 : "+greeting.Length);
            Console.WriteLine();


            //문자열 추출
            Console.WriteLine("greeting 1번째 문자 :" + greeting[0]);
            Console.WriteLine("greeting 6번째 문자 :" + greeting[5]);
            Console.WriteLine("greeting 12번째 문자 :" + greeting[11]);
            Console.WriteLine();


            //문자열 인덱스
            Console.WriteLine("'G'인덱스 :" +greeting.IndexOf('G')); //앞에서 부터
            Console.WriteLine("'M'인덱스 :" +greeting.IndexOf('M'));
            Console.WriteLine("'o'인덱스 :" +greeting.IndexOf('o'));
            Console.WriteLine("'o'인덱스 :" +greeting.LastIndexOf('o')); //뒤에서부터 찾음 
            Console.WriteLine();


            //문자열 자르기
            Console.WriteLine("greeting 0~4까지 문자열:" + greeting.Substring(0, 4));//0에서부터 4개
            Console.WriteLine("greeting 5~7까지 문자열:" + greeting.Substring(5, 7));//5에서부터 7개
            Console.WriteLine("greeting 5~마지막까지 문자열:" + greeting.Substring(5));//5에서부터 끝까지
            Console.WriteLine();


            //문자열 교체
            string replaced = greeting.Replace("Morning", "Afternoon");  //모닝을 에프터눈으로 대체 그릇 옮기면서 교체
            Console.WriteLine(replaced);
            Console.WriteLine();

            //문자열 변환
            int    var1 = 1;
            double var2 = 2.12345;
            bool   var3 = true;

            string str1 = var1.ToString(); //1 -> "1" 이렇게 바꿔줌 
            string str2 = var2.ToString(); //캐스팅과 다름
            string str3 = ""+var3; //이걸 가장 많이 씀

            Console.WriteLine("srt1 :"+str1);
            Console.WriteLine("srt2 :"+str2);
            Console.WriteLine("srt3 :"+str3);
            Console.WriteLine();

            string s1 = "100";
            string s2 = "3.14";
            string s3 = "false";

            int    r1 = int.Parse(s1);
            double r2 = double.Parse(s2);
            bool   r3 = bool.Parse(s3);

            Console.WriteLine("r1:"+r1);
            Console.WriteLine("r2:"+r2);
            Console.WriteLine("r3:"+r3);

            //자주 사용하는 것만 알아봄
        }
    }
}
