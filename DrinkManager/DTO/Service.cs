using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Service
    {
        private int id;
        private String typeservice;
        private String detail;

        public Service(DataRow row)
        {
            id = Convert.ToInt16(row["tserviceid"]);
            typeservice = row["typeservice"].ToString();
            detail = row["detail"].ToString();
        }

        public Service(int id, string typeservice, string detail)
        {
            this.id = id;
            this.typeservice = typeservice;
            this.detail = detail;
        }

        public int Id { get => id; set => id = value; }
        public string Typeservice { get => typeservice; set => typeservice = value; }
        public string Detail { get => detail; set => detail = value; }
    }
}
