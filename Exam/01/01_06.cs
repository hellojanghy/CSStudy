using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/14
 * 이름: 장혜영
 * 내용: 조건문 연습문제
 */
namespace Exam._01
{
    internal class _01_06
    {
        static void Main1(string[] args)
        {
            Console.Write("점수 입력 :");
            int score = int.Parse(Console.ReadLine());
            char grade;

            Console.Write("입력한 점수는 {0}점 이고, 등급은", score);

            if (90 <= score)
            {
                grade = 'A';
            }
            else if (80 <= score)
            {
                grade = 'B';
            }
            else if (70 <= score)
            {
                grade = 'C';
            }
            else if (60 <= score)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            Console.Write(" {0}입니다.", grade);
        }
    }
}
