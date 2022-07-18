using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub03
{
    internal class Calc
    {
        // 싱글톤 객체
        private static Calc instance = new Calc();
        public static Calc Instance { get => instance; }
        private Calc() { }  //set 외부에서 해당 클래스를 new생성하지 못하게 차닩

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Plus(int x, int y) 
        { 
            return x + y;
        }

        public int Multi(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
