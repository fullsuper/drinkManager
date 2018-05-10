using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class TypeItem
    {
        private int id;
        private String typeitem;

        public TypeItem(DataRow row)
        {
            id = Convert.ToInt16(row["titemid"]);
            typeitem = row["typeitem"].ToString();
        }

        public TypeItem(int id, string typeitem)
        {
            this.id = id;
            this.typeitem = typeitem;
        }

        public int Id { get => id; set => id = value; }
        public string Typeitem { get => typeitem; set => typeitem = value; }
    }
}
