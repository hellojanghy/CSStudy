using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class 연습문제
    {
        static void Main1(string[] args)
        {
            //연습문제 p152_07
            
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            switch (a1 % 12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;

                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;

                case 4:
                    Console.WriteLine("쥐");
                    break;
                case 5:
                    Console.WriteLine("소");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;

                    //연습문제 p152_08
                    string m = Console.ReadLine();
                    int m1 = int.Parse(m);

                    if (m1 <= 5 && m1 >= 3)
                    {
                        Console.WriteLine("봄입니다.");
                    }
                    else if (m1 <= 8 && m1 >= 6)
                    {
                        Console.WriteLine("여름입니다.");
                    }
                    else if (m1 <= 11 && m1 >= 9)
                    {
                        Console.WriteLine("가을입니다.");
                    }
                    else if (m1 <= 12 && m1 >= 2)
                    {
                        Console.WriteLine("겨울입니다.");
                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요");
                    }


                    //연습문제 p152_09
                    string c = Console.ReadLine();
                    int x = int.Parse(c);

                    if (x > 10 && x < 20)
                    {
                        Console.WriteLine("조건에 맞습니다.");
                    }

                    //연습문제 p152_09
                    int y, z;


                    if (y > 4)
                    {
                        if (z > 2)
                        {
                            Console.WriteLine(x * y);
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                    }

            }
        }
    }
}
