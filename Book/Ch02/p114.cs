using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2-66~67
namespace Book.Ch02
{
    internal class p114
    {
        static void Main(string[] args)
        {
            double num = 52.273103;

            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));
            Console.WriteLine(num.ToString("0.0000"));
        }
    }
}
