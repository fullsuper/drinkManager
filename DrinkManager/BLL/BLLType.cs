using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.BLL
{
    class BLLType
    {
        private static BLLType instance;
        public static BLLType Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLType();
                }
                return instance;
            }
        }
        public List<DTO.Service> getListService()
        {
            List<DTO.Service> lstServices = new List<DTO.Service>();
            DataSet ds = DAL.DALConnect.Instance.ExecuteQueryDataSet("select * from  TYPE_SERVICES", CommandType.Text);
            DataTable dt = ds.Tables[0];
            foreach(DataRow row in dt.Rows)
            {
                lstServices.Add(new DTO.Service(row));
            }
            return lstServices;
        }
    }
}
