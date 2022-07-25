using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6-21
namespace Book.Ch06
{
    internal class p289
    {
        class Program
        {
            class Product
            {
                public string name;
                public int price;

                public Product (string name, int price)
                {
                    this.name = name;
                    this.price = price;
                }

                ~Product()
                {
                      
                }
            }

         }
    }
}
