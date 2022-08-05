using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/28
 *  이름 : 장혜영
 *  내용 : 스택 연습문제
 */
namespace Exam._05
{
    class Mystack
    {
        const int maxSize = 10;
        private int[] arr = new int[maxSize];
        private int top;

        public Mystack()
        {
            top = 0;
        }

        public void Push(int val)
        {
            if (top < maxSize)
            {
                arr[top] = val;
                top++;
            }
            else
            {
                Console.WriteLine("Stack Full!");
                return;
            }
        }

        public int Pop()
        {
            if (top > 0)
            {
                top--;
                return arr[top];
            }
            else
            {
                Console.WriteLine("Stack Empty!");
                return default(int);
            }
        }
    }


    internal class _05_09
    {
        static void Main2(string[] args)
        {
            Mystack mStack = new Mystack();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = rand.Next();
                mStack.Push(val);
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Pop() = {mStack.Pop()}");
            }
        }
    }
}
