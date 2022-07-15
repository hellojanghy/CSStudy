using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-11
namespace Book.Ch04
{
    internal class p165
    {
        static void Main1(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("입력(exit를 입력하면 종료):");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}
