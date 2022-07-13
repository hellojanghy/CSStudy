using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022 07월 13일
 * 이름 : 장혜영
 * 내용 : 데이터 형식 변환 실습하기 교재 p106
 */
namespace Ch02
{
    internal class _5변환
    {
        static void Main1(string[] args)
        {
            //작은 변수에서 큰 변수 (작은 그릇에서 큰 그릇으로) 반대면 소실이 생김

            byte num1 = 255;   // 1byte 양수만
            short num2 = num1; // 2byte
            int num3 = num2;   // 4byte 

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);


            //큰 변수에서 작은 변수로 데이터 이동

            int var1 = 256;
            short var2 = (short) var1; //그냥 변환하면 에러 남 ()괄호하고 큰 그릇 넣어주면 되 >이게 캐스팅(Casting)
            byte var3 = (byte) var2;   //byte는 255까지만 되서 소실 발생함 0이나오게댐
                                       
            Console.WriteLine("var1: {0}", var1);
            Console.WriteLine("var2: {0}", var2);
            Console.WriteLine("var3: {0}", var3);

            //정수에서 실수
            int a = 1; //4byte 정수형 1
            int b = 2;
            int c = 3; 

            double d1 = a; //8byte 실수형 1.0
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1:{0}",d1);
            Console.WriteLine("d2:{0}",d2);
            Console.WriteLine("d3:{0}",d3); //출력에선 그냥 정수로 나오긴함,,

            //실수에서 정수
            double n1 = 1.2;
            double n2 = 2.14;
            double n3 = 12.123;

            int r1 = (int)n1;
            int r2 = (int)n2;
            int r3 = (int)n3; //이것도 그냥하면 안댐 ()해야댬 암튼 소실됨

            Console.WriteLine("r1:{0}",r1);
            Console.WriteLine("r2:{0}",r2);
            Console.WriteLine("r3:{0}",r3); //반올림은 안되네
        }
    }
}
