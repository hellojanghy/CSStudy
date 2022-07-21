using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/21
 * 이름 : 장혜영
 * 내용 : 인터페이스 연습문제
 */
namespace Exam._03
{
    interface Buyer
    {
        public abstract void Buy();
    }

    interface Seller
    {
        public abstract void Sell();
    }


    class Customers : Buyer, Seller
    {
        public void Sell()
        {
            Console.WriteLine("판매하기");
        }
        public void Buy()
        {
            Console.WriteLine("구매하기");
        }

    }
    internal class _03_10
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Customer();
            Seller seller = new Customer();

            buyer.Buy();
            seller.Sell();
        }
    }
}
