using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkManager.DTO;

namespace DrinkManager.BLL
{
    class BLLTable
    {
        private static BLLTable instance;

        private BLLTable()
        {
            getListTable();
        }
        public static BLLTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLTable();
                }
                return instance;
            }
        }

        public List<DTO.Table> getListTable()
        {

            List<DTO.Table> lstTable = new List<DTO.Table>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from tables",CommandType.Text);

            foreach (DataRow tb in ds.Tables[0].Rows)
            {
                lstTable.Add(new DTO.Table(tb));
            }
            return lstTable;
        }
        public void insertTable(int floor,string position)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into tables(floor,position) values ("+ floor+",N'"+ position +"')",CommandType.Text);
        }
    }
}
