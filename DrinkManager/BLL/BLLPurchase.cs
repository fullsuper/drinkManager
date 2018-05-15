using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.BLL
{
    class BLLPurchase
    {

        private static BLLPurchase instance;
        private bool done =false;
        public static BLLPurchase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLPurchase();
                }
                return instance;
            }
        }

        public bool Done { get => done; set => done = value; }

        public List<DTO.Table> getTableID()
        {
            List<DTO.Table> lstTableID = new List<DTO.Table>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from tables", CommandType.Text);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                lstTableID.Add(new DTO.Table(row));
            }
            return lstTableID;
        }
        public List<DTO.Employee> getStaff()
        {
            List<DTO.Employee> lstStaff = new List<DTO.Employee>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from employees where tserviceid = 1", CommandType.Text);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstStaff.Add(new DTO.Employee(row));
            }
            return lstStaff;
        }
        public List<DTO.Item> getItemByType(String typeitem)
        {
            List<DTO.Item> lstItem = new List<DTO.Item>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from items i join type_items t on i.titemid = t.titemid where typeitem = N'" + typeitem+"'", CommandType.Text);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstItem.Add(new DTO.Item(row));
            }
            return lstItem;
        }
        public List<DTO.TypeItem> getTypeItem()
        {
            List<DTO.TypeItem> lstTypeItem = new List<DTO.TypeItem>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from type_items", CommandType.Text);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstTypeItem.Add(new DTO.TypeItem(row));
            }
            return lstTypeItem;
        }
        public int getCustomerID(String name)
        {
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select cid from customers where name = N'"+name +"'", CommandType.Text);
            if (ds.Tables[0].Rows.Count == 0)
                insertCustomer(name);
            ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select cid from customers where name = N'" + name + "'", CommandType.Text);
            return Convert.ToInt16(ds.Tables[0].Rows[0]["cid"]);

        }
        private void insertCustomer(String name)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into customers(name) values (N'" +name +"')", CommandType.Text);
        }
        private int getStaffID(String name)
        {
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select eid from employees where name = N'" + name + "'", CommandType.Text);
            return Convert.ToInt16(ds.Tables[0].Rows[0]["eid"]);
        }
        private int getItemID(String name)
        {
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select iid from items where nameitem = N'" + name + "'", CommandType.Text);
            return Convert.ToInt16(ds.Tables[0].Rows[0]["iid"]);
        }
        public int getLastBillID()
        {
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select max(bid) bid from bills", CommandType.Text);
            return Convert.ToInt16(ds.Tables[0].Rows[0]["bid"]);
        }
        public void insertBill(DTO.Bill bill)
        {
            int cid = getCustomerID(bill.CustomerName);
            int eid = getStaffID(bill.Cashier);
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into bills(cid,cashier,purchasedate,tid,price) values (" + cid + "," + eid + ",'" + bill.Purchasedate + "'," + bill.Table + ", " +bill.Price+")", CommandType.Text);
        }
        public void insertDetailBill(String item, int bid, int amount)
        {
            int iid = getItemID(item);
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into detail_bills(bid,iid,amount) values (" + bid + "," + iid + "," + amount + ")", CommandType.Text);
        }
        public void updateItems(DTO.DetailBill db)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("update items set amount = amount - " + db.Amount + " where nameitem = N'" + db.Item + "'", CommandType.Text);
        }

    }
}
