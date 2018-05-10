using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    public class DetailBill
    {
        private String item;
        private int bill;
        private int amount;
        private long price;

        public DetailBill(DataRow row)
        {
            item = row["item"].ToString();
            bill = Convert.ToInt16(row["bid"]);
            amount = Convert.ToInt16(row["amount"]);
            price = Convert.ToInt64(row["price"]);
        }

        public DetailBill(string item, int amount, long price)
        {
            this.item = item;
            this.amount = amount;
            this.price = price;
        }

        public DetailBill(string item, int bill, int amount, long price)
        {
            this.item = item;
            this.bill = bill;
            this.amount = amount;
            this.price = price;
        }

        public string Item { get => item; set => item = value; }
        public int Bill { get => bill; set => bill = value; }
        public int Amount { get => amount; set => amount = value; }
        public long Price { get => price; set => price = value; }
    }
}
