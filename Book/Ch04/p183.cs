using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4-27
namespace Book.Ch04
{
    internal class p183
    {
        static void Mai1n(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] strings = input.Split(new char[] { ' ' });

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
