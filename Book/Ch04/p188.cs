using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-33
namespace Book.Ch04
{
    internal class p188
    {
        static void Mai1n(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;

                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽로 이동");
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;

                    case ConsoleKey.X:
                        break;
                }
            }
        }
    }
}
