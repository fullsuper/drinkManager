using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.BLL
{
    class BLLSupplier
    {

        private static BLLSupplier instance;

        private BLLSupplier()
        {

        }
        public static BLLSupplier Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLSupplier();
                }
                return instance;
            }
        }

        public DataSet getSupplierEmployee()
        {
            return DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from suppliers",CommandType.Text);
        }
        public void deleteSupplier(int sid)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("delete from suppliers where sid = " +sid, CommandType.Text);
        }
        public void insertSupplier(DTO.Supplier sup)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into suppliers(name,address,phone) values(N'"+sup.Name+"',N'"+sup.Address+"',"+sup.Phone+")" , CommandType.Text);
        }
        public void customSupplier(DTO.Supplier sup)
        {
           DAL.DALConnect.Instance.MyExecuteNonQuery("update suppliers set name = N'" + sup.Name +"', address = N'"+sup.Address+"',phone = " +sup.Phone+" where sid =" +sup.Id, CommandType.Text);
        }

    }
}
