﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5-20
namespace Book.Ch05
{
    internal class p234
    {
        class Student
        {
            public string name;
            public int grade;

        }

        static void Main1(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2});
            list.Add(new Student() { name = "윤아린", grade =3 });
            list.Add(new Student() { name = "윤명월", grade =4 });
            list.Add(new Student() { name = "구지연", grade =1 });
            list.Add(new Student() { name = "김연화", grade =2 });

        }
    }
}