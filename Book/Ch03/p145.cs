using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3-15
namespace Book.Ch03
{
    internal class p145
    {
        static void Mai1n(string[] args)
        {
            Console.WriteLine("입력:");
            string line = Console.ReadLine();

            if(line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
                   
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
    }
}
