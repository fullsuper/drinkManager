﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.BLL
{
    class BLLBill
    {
        private static BLLBill instance;
        public static BLLBill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLBill();
                }
                return instance;
            }
        }
        public DataSet getBillTable()
        {
            return DAL.DALConnect.Instance.ExecuteQueryDataSet("select bid, c.name as customer, price, s.name as staff, purchasedate,tid " +
                "from bills b join customers c on b.cid = c.cid " +
                "join employees s on b.cashier = s.eid", CommandType.Text);
        }
        public DataTable findData(String cus, String fromPrice,String toPrice, String staff,String fromDate, String toDate, String table)
        {
            string strData = "select bid, c.name as customer, price, s.name as staff, purchasedate,tid "
                +"from bills b join customers c on b.cid = c.cid "
                + "join employees s on b.cashier = s.eid where ";

            if (cus != "")
                strData += " c.name = N'" + cus + "' and ";
            if (fromPrice != "")
                strData += " price >= " + fromPrice + " and ";
            if (toPrice != "")
                strData += " price <= " + toPrice + " and ";
            if (staff != "")
                strData += " s.name = N'" + staff + "' and ";
            if (fromDate != "")
                strData += " purchasedate >= '" + fromDate + "' and ";
            if (toDate != "")
                strData += " purchasedate <= '" + toDate + "' and ";
            if (table != "")
                strData += " tid = " + table;
            else
                strData = strData.Remove(strData.Length - 5, 4);

            return DAL.DALConnect.Instance.ExecuteQueryDataSet(strData, CommandType.Text).Tables[0];
        }
        public List<DTO.DetailBill> getListItemInBill(int bid)
        {
            List<DTO.DetailBill> lstDB = new List<DTO.DetailBill>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select nameitem as item, db.amount as amount, price , bid from DETAIL_BILLS db join ITEMS i on db.iid = i.iid where bid =" +bid, CommandType.Text);
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                lstDB.Add(new DTO.DetailBill(row));
            }
            return lstDB;
        }
        public DTO.Bill getBill(int bid)
        {
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select bid, c.name as customer, price, s.name as staff, purchasedate, tid " +
                "from bills b join customers c on b.cid = c.cid " +
                "join employees s on b.cashier = s.eid where bid =" + bid, CommandType.Text);
            DataRow row = ds.Tables[0].Rows[0];
            DTO.Bill bill = new DTO.Bill(row);
            return bill;
        }
    }
}
