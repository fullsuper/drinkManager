using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Item
    {
        private int id;
        private String typeitem;
        private String nameitem;
        private long price;
        private int amount;

        public Item(DataRow row)
        {
            id = Convert.ToInt16(row["iid"]);
            typeitem = row["typeitem"].ToString();
            nameitem = row["nameitem"].ToString();
            price = Convert.ToInt64(row["price"]);
            amount = Convert.ToInt16(row["amount"]);
        }

        public Item(string typeitem, string nameitem, long price, int amount)
        {
            this.typeitem = typeitem;
            this.nameitem = nameitem;
            this.price = price;
            this.amount = amount;
        }

        public Item(int id, string typeitem, string nameitem, long price, int amount)
        {
            this.id = id;
            this.typeitem = typeitem;
            this.nameitem = nameitem;
            this.price = price;
            this.amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public string Typeitem { get => typeitem; set => typeitem = value; }
        public string Nameitem { get => nameitem; set => nameitem = value; }
        public long Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
