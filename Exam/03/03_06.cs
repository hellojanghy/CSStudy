using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/21
 * 이름 : 장혜영
 * 내용 : 클래스 상속 연습문제
 */
namespace Exam._03
{
    class Rent
    {
        public void Payment()
        {
            Console.WriteLine("임대료를 받습니다.");
        }
    }
    
    class Landload : Rent
    {
        public void GetMoney()
        {
            Console.WriteLine("건물주 입니다.");
            Payment();
        }
    }

    internal class _03_06
    {
        static void Main1(string[] args)
        {
            Landload master = new Landload();
            master.GetMoney();
        }
    }
}
