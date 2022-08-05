using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    class Member
    {
        public int Age { get; init; }
        public string Name { get; init; }
        public string Hp { get; init; }

        public override string ToString()
        {
            return $"{Name},{Hp},{Age}";
        }
    }
    internal class _10_08
    {
    static void Mai1n(string[] args)
    {
        //Member m1 = new Member(Name = "장보고", Hp = "010-1234-1003", Age = 33);
    }
    }
}
