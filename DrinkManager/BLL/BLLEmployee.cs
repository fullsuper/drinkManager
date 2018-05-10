using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.BLL
{
    class BLLEmployee
    {
        private static BLLEmployee instance;
        private static List<DTO.Service> lstService;
        public static BLLEmployee Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLEmployee();
                }
                return instance;
            }
        }
        public static List<DTO.Service> LisService
        {
            get { return lstService; }
        }
        private BLLEmployee()
        {
            getListService();
        }
       
        private void getListService()
        {
            DataSet dsService = DAL.DALConnect.Instance.ExecuteQueryDataSet("Select * from type_services", CommandType.Text);
            DataTable dtService = dsService.Tables[0];
            lstService = new List<DTO.Service>();
            foreach(DataRow dr in dtService.Rows)
            {
                lstService.Add(new DTO.Service(dr));
            }
        }
        private int getTypeID(String typeservice)
        {
            foreach (DTO.Service dr in lstService)
            {
                if (dr.Typeservice.Equals(typeservice))
                    return dr.Id;
            }
            return -1;
        }
        public DataSet getTableEmployee()
        {
            return DAL.DALConnect.Instance.ExecuteQueryDataSet("select eid,name,typeservice,hiredate,salary,phone from employees e join TYPE_SERVICES t on e.tserviceid = t.tserviceid", CommandType.Text);
        }

        public void deleteEmployee(int id)
        {
            DAL.DALConnect.Instance.MyExecuteNonQuery("delete from employees where eid = " +id,CommandType.Text);
        }
        public void insertNewEmploy(DTO.Employee emp)
        {
            int tid = getTypeID(emp.Typeservice);
            DAL.DALConnect.Instance.MyExecuteNonQuery("insert into EMPLOYEES(name,hiredate,tserviceid,phone,salary) values (N'" +emp.Name +"','" + emp.Hiredate +"'," + tid+ "," + emp.Phone+"," + emp.Salary+")", CommandType.Text);
        }
        public void updateEmployee(DTO.Employee emp)
        {
            int tid = getTypeID(emp.Typeservice);
            DAL.DALConnect.Instance.MyExecuteNonQuery("update EMPLOYEES set tserviceid = " + tid + ", name = N'" + emp.Name + "',hiredate = '" + emp.Hiredate+"',phone = " + emp.Phone + ", salary = " + emp.Salary + " where eid =" + emp.Id, CommandType.Text);
        }
    }
}
