using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class 연습문제
    {
        static void Main1(string[] args)
        {
            //연습문제 p123_11
            string rinch = Console.ReadLine();
            double cm = 2.54;
            double inch = double.Parse(rinch) * cm;
            Console.WriteLine(inch);

            //연습문제 p123_12
            string rkg = Console.ReadLine();
            double pound = 2.20462262;
            double kg = double.Parse(rkg) * pound;
            Console.WriteLine(kg);

            //연습문제 p123_12
            string r = Console.ReadLine();
            double pi = 3.14;
            double d = 2 * pi;
            double R = double.Parse(r);
            double l = pi * (R * R) ;
            Console.WriteLine("둘레는 : {0}, 넓이는 :{1}",d,l);

            //연습문제 p124_13
            Console.WriteLine(52+273);
            Console.WriteLine(52+"273");
            Console.WriteLine("52"+273);
            Console.WriteLine("52"+"273");

        }
    }
}
