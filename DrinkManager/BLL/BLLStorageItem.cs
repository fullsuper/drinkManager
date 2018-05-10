using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkManager.DAL;

namespace DrinkManager.BLL
{

    class BLLStorageItem
    {
        private static BLLStorageItem instance;

        public static BLLStorageItem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLStorageItem();
                }
                return instance;
            }
        }

        public DataTable StorageItemTable()
        {
            return DALConnect.Instance.ExecuteQueryDataSet("select iid, typeitem, " +
                "nameitem,price,amount from ITEMS I join TYPE_ITEMS t on i.titemid = t.titemid", CommandType.Text).Tables[0];
        }
        public void InsertNewItem(DTO.Item item)
        {
            int tid = Convert.ToInt16(DALConnect.Instance.ExecuteQueryDataSet("select titemid from TYPE_ITEMS where typeitem = N'" + item.Typeitem + "'",CommandType.Text).Tables[0].Rows[0]["titemid"]);
            DALConnect.Instance.MyExecuteNonQuery("insert into ITEMS(titemid, nameitem, price, amount) values("+tid+", N'"+item.Nameitem+ "', "+item.Price+","+item.Amount +");", CommandType.Text);
        }
        public void UpdateItem(DTO.Item item)
        {
            int tid = Convert.ToInt16(DALConnect.Instance.ExecuteQueryDataSet("select titemid from TYPE_ITEMS where typeitem = N'" + item.Typeitem + "'", CommandType.Text).Tables[0].Rows[0]["titemid"]);
            DALConnect.Instance.MyExecuteNonQuery("update ITEMS set titemid = "+tid+", nameitem = N'" + item.Nameitem + "',price = "+item.Price+", amount = "+item.Amount+" where iid =" +item.Id, CommandType.Text);
        }
        public void DeleteItem(int id)
        {
            DALConnect.Instance.MyExecuteNonQuery("delete from ITEMS where iid =" + id, CommandType.Text);
        }

    }
}
