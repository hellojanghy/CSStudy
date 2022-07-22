using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/22
 *  이름 : 장혜영
 *  내용 : 객체 배열 연습문제
 */
namespace Exam._04
{
    class Aritists
    {
        
        public string Name { get; set; }
        public string Country { get; set; }
        public int Brith { get; set; }

        public Aritists(string name, string country, int brith)
        {
            Name = name;
            Country = country;
            Brith = brith;
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2}", Name, Country, Brith);
        }
    }

    internal class _04_07
    {
        static void Main(string[] args)
        {
            Aritists[] famousArts = {
                new Aritists("레오나드로 다빈치", "이탈리아", 1452),
                new Aritists("미켈란젤로", "이탈리아", 1475),
                new Aritists("빈센트 반 고흐", "네덜란드", 1853),
                new Aritists("클로드 모네", "프랑스", 1840),
                new Aritists("파블로 피카소", "스페인", 1881),
            };

            foreach (Aritists item in famousArts)
            {
                Console.WriteLine(famousArts.ToString());
            }
        }
    }
}
