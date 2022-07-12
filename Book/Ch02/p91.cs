using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-37~38
namespace Book.Ch02
{
    internal class p91
    {
        static void Main1(string[] args)
        {
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);


            int output2 = 0;
            output2 = output2 + 52;
            output2 = output2 + 273;
            output2 = output2 + 103;

            Console.WriteLine(output2);
        }
    }
}
