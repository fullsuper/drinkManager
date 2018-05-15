using System;
using System.Collections.Generic;
using System.Data;

namespace DrinkManager.BLL
{
    class BLLImportGoods
    {
        private static BLLImportGoods instance;

        public static BLLImportGoods Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLImportGoods();
                }
                return instance;
            }
        }
        public DataTable getItemTable()
        {
            return DAL.DALConnect.Instance.ExecuteQueryDataSet("select iid,nameitem,amount from items", CommandType.Text).Tables[0];
        }
        public List<String> getListSupplier()
        {
            List<String> lstSup = new List<String>();
            DataRowCollection drc = DAL.DALConnect.Instance.ExecuteQueryDataSet("select name from suppliers", CommandType.Text).Tables[0].Rows;
            foreach(DataRow dr in drc)
            {
                lstSup.Add(dr["name"].ToString());
            }
            return lstSup;
        }
        public List<String> getListCensor()
        {
            List<String> lstCensor = new List<String>();
            DataRowCollection drc = DAL.DALConnect.Instance.ExecuteQueryDataSet("select name from employees where tserviceid = 2", CommandType.Text).Tables[0].Rows;
            foreach (DataRow dr in drc)
            {
                lstCensor.Add(dr["name"].ToString());
            }
            return lstCensor;
        }
        public int getIDSupplier(string name)
        {
            DataRow dr = DAL.DALConnect.Instance.ExecuteQueryDataSet("select sid from suppliers where name = N'" +name +"'", CommandType.Text).Tables[0].Rows[0];
            return Convert.ToInt16(dr["sid"]);
        }
        public int getIDCensor(string name)
        {
            DataRow dr = DAL.DALConnect.Instance.ExecuteQueryDataSet("select eid from employees where name = N'" + name + "'", CommandType.Text).Tables[0].Rows[0];
            return Convert.ToInt16(dr["eid"]);
        }
        public void insertShipment(DTO.Shipment sm)
        {
            int eid = getIDCensor(sm.Censor);
            int sid = getIDSupplier(sm.Supplier);
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into shipments(tradingdate,censor,sid,rate) values ('"+sm.Tradingdate +"',"+eid+ "," +sid+",N'"+sm.Rate+"')", CommandType.Text);
        }
        public int getIDLastShipment()
        {
            DataRow dr = DAL.DALConnect.Instance.ExecuteQueryDataSet("select max(shid) as shid from shipments ", CommandType.Text).Tables[0].Rows[0];
            return Convert.ToInt16(dr["shid"]);
        }
        public void insertDetailShipment(DTO.DetailShipment ds)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into detail_shipments(shid,iid,amount) values (" + ds.Shipment + "," + ds.Iid + "," + ds.Amount +")", CommandType.Text);
        }
        public void updateItem(DTO.DetailShipment ds)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("update items set amount = amount + " +ds.Amount +" where iid = "+ds.Iid, CommandType.Text);
        }
    }
}
