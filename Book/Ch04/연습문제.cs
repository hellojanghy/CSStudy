using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class 연습문제
    {
        static void Main(string[] args)
        {
            //연습문제 p197_10

            /*int i = 0;
            while (i < 10)
            {
                Console.WriteLine("출력");
                i++;
            }
            */
            //연습문제 p197_11


            //연습문제 p197_12]
            Console.Write("숫자를 입력해주세요 :");
            string a1 = Console.ReadLine();
            Console.Write("숫자를 입력해주세요 :");
            string a2 = Console.ReadLine();
            Console.Write("숫자를 입력해주세요 :");
            string a3 = Console.ReadLine();
            Console.Write("숫자를 입력해주세요 :");
            string a4 = Console.ReadLine();
            Console.Write("숫자를 입력해주세요 :");
            string a5 = Console.ReadLine();
            Console.WriteLine("-------------------------------------");


            int r1 = int.Parse(a1);
            int r2 = int.Parse(a2);
            int r3 = int.Parse(a3);
            int r4 = int.Parse(a4);
            int r5 = int.Parse(a5);

            int[] arr = new int[5];
            arr[0] = r1;
            arr[1] = r2;
            arr[2] = r3;
            arr[3] = r4;
            arr[4] = r5;

           
            
            for (int x = 0; x < 5; x++)
            {
                int y = x + 1;

                if (arr[x] < arr[y])
                {
                    arr[x] = arr[y];
                }
                
                    
                
                Console.WriteLine("가장 큰 수 :" + arr[x]);
            }

            Console.WriteLine("가장 작은 수 :");
        }
    }
}
