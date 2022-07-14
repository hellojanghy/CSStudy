using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/14
 * 이름: 장혜영
 * 내용: 문자열 처리 연습문제
 */
namespace Exam._01
{
    internal class _01_05
    {
        static void Main1(string[] args)
        {
            string strSroce = "60, 72, 82, 86, 92";
            string[] scores = strSroce.Split(",");

                int total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                total += int.Parse(scores[i]);
            }
            Console.WriteLine("총점 :" + total); 
        }
        
    }
}
