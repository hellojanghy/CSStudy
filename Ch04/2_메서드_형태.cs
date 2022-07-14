using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/14
 * 이름 : 장혜영
 * 내용 : 메서드 타입 실습하기 교재 p265
 */
namespace Ch04
{
    internal class _2_메서드형태
    {
        static void Mai1n(string[] args)
        {
            //메서드 호출
            double y1 = Type1(0.12); //인자값 0.12 전달
            double y2 = Type1(1.1); //인자값 1.13 전달

            Console.WriteLine("y1 :"+ y1);
            Console.WriteLine("y2 :"+ y2);
            Console.WriteLine();

            //메서드 호출
            Type2(true);  //리턴이 없기 때문에 대입 연산자 쓰지 않음
            Type2(false);
            Console.WriteLine();

            //메서드 호출
            string result = Type3();
            Console.WriteLine("Type3 result :"+ result);


            Type4();
        }//end of Main

        //Type1 : 매개변수 O, 리턴값O
        public static double Type1(double x) 
        {
            double y = x + Math.PI;
            return y;
        }


        //Type1 : 매개변수 O, 리턴값X  
        public static void Type2(bool status) 
        {
         if (status)
            {
                Console.WriteLine("참 입니다.");
            }
         else
            {
                Console.WriteLine("거짓 입니다.");
            }
        }
        

        //Type1 : 매개변수 X, 리턴값O
        public static string Type3() 
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 < n2)
            {
                return "n1은 n2보다 크다";
            }
            else
            {
                return "n1은 n2보다 작다";
            }
        }


        //Type1 : 매개변수 X, 리턴값X
        public static void Type4()
        {
            Console.WriteLine("Type4 result :" + Type1(1.12));
            
        }
    }
}
