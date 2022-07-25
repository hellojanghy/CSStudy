using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/25
 * 이름 : 장혜영
 * 내용 : 컬렉션 리스트 실습하기 교재 p211
 * 
 *  리스트(List)
 *   - 배열과 유사한 선형자료구조로 배열과 다르게 동적으로 데이터를 처리
 *   - ArrayList를 일반화 시켜 더 나은 성능을 가진 List를 사용
 */
namespace Ch07
{
    internal class _3_List
    {
        static void Main1(string[] args)
        {
            ///////////////////////////
            /// ArrayList
            ///////////////////////////
           
            
            // ArrayList 생성
            ArrayList arrList1 = new ArrayList();

            // 데이터 추가
            arrList1.Add(1);
            arrList1.Add(2);
            arrList1.Add(3);
            arrList1.Add(4);
            arrList1.Add(5);

            // 데이터 삽입
            arrList1.Insert(1, 6); // 1,2,3,4,5 > 1,6,2,3,4,5 이렇게 댐
                
            // 데이터 삭제
            arrList1.Remove(6); //6번째 칸을 삭제하는 게 아님 6을 지우는 거
            arrList1.RemoveAt(0); //이건 칸 맞음

            // 데이터 출력
            foreach (int n in arrList1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // 다양한 타입의 데이터를 갖는 ArrayList
            ArrayList arrList2 = new ArrayList();
            arrList2.Add(1);
            arrList2.Add(1.23);
            arrList2.Add(true);
            arrList2.Add('A');
            arrList2.Add("Apple");


            for (int i = 0; i <= arrList2.Count ; i++)
            {
                Console.Write(arrList2[i] + " ");
            }

            Console.WriteLine();
            ///////////////////////////
            /// List
            ///////////////////////////

            // List 생성
            List<int> list1 = new List<int>();

            // 데이터 추가
            list1.Add(1);
                list1.Add(2);
                list1.Add(3);
                list1.Add(4);
                list1.Add(5);

            // 데이터 삽입
            list1.Insert(1, 6);

            // 데이터 삭제
            arrList1.Remove(4); 
            arrList1.RemoveAt(1);

            // 데이터 출력
            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }

            List<string> list2 = new List<string>();
            list2.Add("서울");
            list2.Add("대전");
            list2.Add("대구");
            list2.Add("부산");
            list2.Add("광주");

            foreach (string city in list2)
            {
                Console.Write(city + " ");
            }

            //List<Apple> list3 = new<Apple>();

            //list3.Add(new Apple("한국", 3000));
            //list3.Add(new Apple("일본", 2000));
            //list3.Add(new Apple("미국", 1000));

            //Apple apple = List(3[0]);
            //apple.Show();

            //list3[2].Show();
            //list3[3].Show();
        }
    }
}
