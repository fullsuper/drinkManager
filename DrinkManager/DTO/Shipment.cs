using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class Shipment
    {
        private int id;
        private DateTime tradingdate;
        private String censor;
        private String supplier;
        private String rate;

        public Shipment(DataRow row)
        {
            id = Convert.ToInt16(row["shid"]);
            tradingdate = Convert.ToDateTime(row["tradingdate"]);
            censor = row["censor"].ToString();
            supplier = row["supplier"].ToString();
            rate = row["rate"].ToString();
        }

        public Shipment(DateTime tradingdate, string censor, string supplier, string rate)
        {
            this.tradingdate = tradingdate;
            this.censor = censor;
            this.supplier = supplier;
            this.rate = rate;
        }

        public Shipment(int id, DateTime tradingdate, string censor, string supplier, string rate)
        {
            this.id = id;
            this.tradingdate = tradingdate;
            this.censor = censor;
            this.supplier = supplier;
            this.rate = rate;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tradingdate { get => tradingdate; set => tradingdate = value; }
        public string Censor { get => censor; set => censor = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public string Rate { get => rate; set => rate = value; }
    }
}
