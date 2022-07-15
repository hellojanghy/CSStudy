using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-30~31
namespace Book.Ch04
{
    internal class p186
    {
        static void Mai1n(string[] args)
        {
            Console.WriteLine("메서드 호출 전");
            Console.SetCursorPosition(5,5);
            Console.WriteLine("메서드 호출 후");

            Console.WriteLine("첫번째 출력");
            Thread.Sleep(1000);
            
            Console.WriteLine("두번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세번째 출력");
        }
    }
}
