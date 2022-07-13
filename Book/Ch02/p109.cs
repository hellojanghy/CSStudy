using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-61
namespace Book.Ch02
{
    internal class p109
    {
        static void Mai1n(string[] args)
        {
            int inum = 2147483647;

            long ilong = inum;
            Console.WriteLine(ilong);

            double id = inum;
            Console.WriteLine(id);
        }
    }
}
