using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/13
 * 이름 : 장혜영
 * 내용 : 반복문 While 실습하기 교재 p162
 */
namespace Ch03
{
    internal class _4_While문 //특정 조건이 만족할때까지 (조건이 거짓이 될 때 까지)
    {
        static void Main1(string[] args)
        {
            // while
            int sum = 0; 
            int k = 3; 

            while (k<= 10) //이게 될때까지
            {
                sum += k;
                k++;
            }

            Console.WriteLine("1부터 10까지 합 :" +sum);


            // do ~ while : 최초 1번 반복을 수행하는 반복문
            int total = 0;
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
                
                i++;

            }
            while ( i <= 10);

            Console.WriteLine("1부터 10까지 짝수합 :" + total);


            // break
            int num = 1;

            while(true)
            {

                if(num % 5 == 0 && num % 7 == 0)
                {
                    break; //반복문 종료
                }
                num++;
            }

            Console.WriteLine("5화 7의 최소공배수 :" +num);


            // continue
            int tot = 0;
            int n = 0;

            while(n <= 10)
            {
                n++;

                if(n % 2 == 1) //n값이 홀수면 위로 올려라 짝수면 밑으로 내려가서 더해라
                {
                    // 홀수이면 반복문의 처음으로 이동
                    continue; //밑으로 안내려가고 위로 다시 처음으로 이동시킴
                }
                //짝수이면
                tot += n; 
            }

            Console.WriteLine("1부터 10까지 짝수 합 :" +tot);
        }
    }
}
