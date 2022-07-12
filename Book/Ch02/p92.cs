using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-39~40
namespace Book.Ch02
{
    internal class p92
    {
        static void Main1(string[] args)
        {
            string output = "hello";
            output += "world";
            output += "!";

            Console.WriteLine(output);

            string output2 = "hello";
            output2 = output2 + "World";
            output2 = output2 + "!";
        }
    }
}
