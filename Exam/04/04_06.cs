using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/22
 *  이름 : 장혜영
 *  내용 : Indexer 연습문제
 */
namespace Exam._04
{
    class MyIndexer<T>
    {
        private T[] array = new T[10];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    internal class _04_06
    {
        static void Main1(string[] args)
        {
            var MyIndexer = new MyIndexer<string>();

            MyIndexer[0] = "Hello, World!";
            MyIndexer[1] = "Hello, Korea!";
            MyIndexer[2] = "Hello, Busan!";
            MyIndexer[3] = "Hello, C#!";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(MyIndexer[i]);
            }
        }
    }
}
