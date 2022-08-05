using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단계
{
    internal class _04_01
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');

                int x = 0;
                int y = 0;
                
            for (int i = 0; i >= a.Length; i++)
            {
                
                if (x < int.Parse(a[i]))
                {
                    x = int.Parse(a[i]);
                }
                if (y > int.Parse(a[i]))
                {
                    y = int.Parse(a[i]);
                }

            }
            Console.WriteLine( "{0} {1}",x,y );
            
        }
    }
}
