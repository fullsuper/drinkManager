using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    public class Bill
    {
        private int id;
        private String customerName;
        private long price;
        private String cashier;
        private DateTime purchasedate;
        private int table;

        public Bill(DataRow row)
        {
            id = Convert.ToInt16(row["bid"]);
            customerName = row["customer"].ToString();
            price = Convert.ToInt64(row["price"]);
            cashier = row["staff"].ToString();
            purchasedate = Convert.ToDateTime(row["purchasedate"]);
            table = Convert.ToInt16(row["tid"]);
        }

        public Bill(string customerName, long price, string cashier, DateTime purchasedate, int table)
        {
            this.customerName = customerName;
            this.price = price;
            this.cashier = cashier;
            this.purchasedate = purchasedate;
            this.table = table;
        }

        public Bill(int id, string customerName, long price, string cashier, DateTime purchasedate, int table)
        {
            this.id = id;
            this.customerName = customerName;
            this.price = price;
            this.cashier = cashier;
            this.purchasedate = purchasedate;
            this.table = table;
        }

        public int Id { get => id; set => id = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public long Price { get => price; set => price = value; }
        public string Cashier { get => cashier; set => cashier = value; }
        public DateTime Purchasedate { get => purchasedate; set => purchasedate = value; }
        public int Table { get => table; set => table = value; }
    }
}
