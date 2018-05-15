using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DTO
{
    class DetailShipment
    {
        private int id;
        private int shipment;
        private int iid;
        private int amount;

        public DetailShipment(int shipment, int iid, int amount)
        {
            this.shipment = shipment;
            this.iid = iid;
            this.amount = amount;
        }

        public DetailShipment(int id, int shipment, int iid, int amount)
        {
            this.id = id;
            this.shipment = shipment;
            this.iid = iid;
            this.amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Shipment { get => shipment; set => shipment = value; }
        public int Iid { get => iid; set => iid = value; }
    }
}
