using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5-6~7
namespace Book.Ch05
{
    internal class p213
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach (var item in list)
            {
                Console.WriteLine("Count:"+list.Count + "\titem:" +item);
            }


            List<int> list2 = new List<int>() { 52,273,32,64};


            foreach (var item2 in list2)
            {
                Console.WriteLine("Count:" + list2.Count + "\titem:" + item2);
            }
        }
    }
}
