using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-59~60
namespace Book.Ch02
{
    internal class p108
    {
        static void Mai1n(string[] args)
        {
            long lnum = 52273;
            int inum = (int)lnum;
            Console.WriteLine(inum);

            long linum = 2147483647L + 2147483647L;
            int iinum = (int)lnum;
            Console.WriteLine(inum);

            double dnum = 52.27310332;
            int idnum = (int)dnum;

            Console.WriteLine(idnum);
        }
    }
}
