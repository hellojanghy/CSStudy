using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5-13~4
namespace Book.Ch05
{
    internal class p227
    {
        class Product
        {
            public string Name = "default";
            public int price = 1000;
        }

        static void Mai1n(string[] args)
        {
            Product product = new Product();

            product.Name = "감자";
            product.price = 2000;

            Console.WriteLine(product.Name+":"+ product.price+"원");
        }
    }
}
