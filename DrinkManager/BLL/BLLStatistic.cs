using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.BLL
{
    class BLLStatistic
    {
        private static BLLStatistic instance;
        public static BLLStatistic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLStatistic();
                }
                return instance;
            }
        }

        public DataTable getFriendlyCustomerTable()
        {
            return DAL.DALConnect.Instance.ExecuteQueryDataSet("select c.cid,c.name, count(*) time,sum(b.price) sumprice  from customers c join bills b on c.cid = b.cid group by c.cid,c.name", CommandType.Text).Tables[0];
        }
        public DataTable getFriendlyCustomerByTime(int month,int year)
        {
            return DAL.DALConnect.Instance.ExecuteQueryDataSet("select c.cid,c.name, count(*) time,sum(b.price) sumprice  from customers c join (select * from bills where month(purchasedate) ="+month+ "and year(purchasedate) = "+year+") b on c.cid = b.cid group by c.cid,c.name", CommandType.Text).Tables[0];
        }
        public long monthlyIncome(int month,int year)
        {
            DataTable dt = DAL.DALConnect.Instance.ExecuteQueryDataSet("select  sum(price) sum from bills where MONTH(purchasedate) =" +month + " and year(purchasedate) = " + year, CommandType.Text).Tables[0];
            try
            {
                return Convert.ToInt64(dt.Rows[0]["sum"]);
            }
            catch { return 0; }
        }
    }
}
