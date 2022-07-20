using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6-3
namespace Book.Ch06
{
    internal class p268
    {
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }

        static void Mai1n(string[] args)
        {
            Test test = new Test();
            test.Print();
            test.Print();
            test.Print();
        }
    }
}
