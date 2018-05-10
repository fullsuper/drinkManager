using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Table
    {
        private int id;
        private int floor;
        private String position;

        public Table(DataRow row)
        {
            id = Convert.ToInt16(row["tid"]);
            floor = Convert.ToInt16(row["floor"]);
            position = row["position"].ToString();
        }

        public Table(int id, int floor, string position)
        {
            this.id = id;
            this.floor = floor;
            this.position = position;
        }

        public int Id { get => id; set => id = value; }
        public int Floor { get => floor; set => floor = value; }
        public string Position { get => position; set => position = value; }
    }
}
