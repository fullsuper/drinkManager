using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Supplier
    {
        private int id;
        private String name;
        private String address;
        private long phone;

        public Supplier(DataRow row)
        {
            id = Convert.ToInt16(row["sid"]);
            name = row["name"].ToString();
            address = row["address"].ToString();
            phone = Convert.ToInt64(row["phone"]);
        }

        public Supplier(string name, string address, long phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public Supplier(int id, string name, string address, long phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public long Phone { get => phone; set => phone = value; }
    }
}
