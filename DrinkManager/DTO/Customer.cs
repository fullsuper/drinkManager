using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Customer
    {
        private int id;
        private String name;
        private String info;

        public Customer(DataRow row)
        {
            id = Convert.ToInt16(row["cid"]);
            name = row["name"].ToString();
            info = row["info"].ToString();
        }

        public Customer(int id, string name, string info)
        {
            this.id = id;
            this.name = name;
            this.info = info;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Info { get => info; set => info = value; }
    }
}
