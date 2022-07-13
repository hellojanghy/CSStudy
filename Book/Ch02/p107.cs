using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-57~58
namespace Book.Ch02
{
    internal class p107
    {
        static void Mai1n(string[] args)
        {
            var a = (int)10.0;
            var b = (float)10.0;
            var c = (double)10.0;

            long lnum = 2147483647L + 2147483647L;
            int inum = (int)lnum;
            Console.WriteLine(inum);
        }
    }
}
