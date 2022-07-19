using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub04
{
    internal class StockAccount : Account
    {
        private string stock;
        private int amont;
        private int price;

        public StockAccount(string bank, string id, string name, int balance, string stock, int amont,int price) : base(bank, id, name, balance)
        {
             this.stock = stock;
             this.amont = amont;
             this.price = price;
        }

        public void Sell(int amont, int price)
        {
            this.amont -= amont;
            base.balance += amont * price;
        }

        public void Buy(int amont, int price)
        {
            this.amont += amont;
            base.balance -= amont * price;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("주식종목 :" + stock);
            Console.WriteLine("주식수량 :" + amont);
            Console.WriteLine("주식가격 :" + price);
            Console.WriteLine("-----------------");
        }
    }
}
