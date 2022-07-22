using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/22
 *  이름 : 장혜영
 *  내용 : 클래스 상속 연습문제
 */
namespace Exam._04
{
    class Person
    { 
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Hello()
        {
            
            Console.WriteLine("이름 :" +name);
            Console.WriteLine("나이 :" +age);
        }
    }
    
    class Student : Person
    {
        private string school;
        private string major;

        public Student(string name, int age, string school, string major) : base(name, age)
        {
            this.school = school;
            this.major = major;
        }
    }

    class SalaryStudent : Student
    {
        private string company;

        public SalaryStudent(string name, int age, string school, string major, string company) : base(name, age, school, major)
        {
            this.company = company;
        }

        public new void Hello()
        {
            base.Hello();
            Console.WriteLine("회사 :" + company);
        }
    }
    internal class _04_09
    {
        static void Main(string[] args)
        {
            Person kim = new Person("김유신", 24);
            Student jang = new Student("장보고", 26,"부경대","영문학과");
            SalaryStudent lee = new SalaryStudent("김유신", 24, "부산대", "경제학과","삼성전자");

            kim.Hello();
            Console.WriteLine("---------------------");

            jang.Hello();
            Console.WriteLine("---------------------");

            lee.Hello();
            Console.WriteLine("---------------------");
        }
    }
}
