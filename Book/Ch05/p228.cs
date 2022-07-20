using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5-15
namespace Book.Ch05
{
    internal class p228
    {
        class Product
        {
            public string Name;
            public int price;
        }

        static void Main1(string[] args)
        {
            Product productA = new Product() { Name = "감자", price = 2000 };
            Product productB = new Product() { Name = "고구마", price = 3000 };


            Console.WriteLine(productA.Name+":"+ productA.price+"원");
            Console.WriteLine(productB.Name+":"+ productB.price+"원");
        }
    }
}
