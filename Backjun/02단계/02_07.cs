using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_07
    {
        static void Main1(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int A = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);
            int C = int.Parse(arr[2]);

            if (A == B && B == C)
            {
                Console.Write(10000 + A * 1000);
            }
            else if (A == B || A == C)
            {
                Console.WriteLine(1000 + A * 100);
            }
            else if (B == C)
            {
                Console.WriteLine(1000 + B * 100);
            }
            else
            {
                    if (A > B && A > C)
                    {
                        Console.WriteLine(A * 100);
                    }
                    else if(B > A && B > C)
                    {
                        Console.WriteLine(B * 100);
                    }
                    else
                    {
                        Console.WriteLine(C * 100);
                    }
                }

            
            
        }
    }
}
