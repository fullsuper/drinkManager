using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManager.DAL
{

   
    class DALConnect
    {
        private static DALConnect instance;
        private SqlConnection conn = null;
        private SqlCommand comm = null;
        private SqlDataAdapter da = null;
        static string connString;

        private DALConnect() {
            connString = "Data Source=DESKTOP-ASM8D83\\SQLEXPRESS;Initial Catalog=QUANLYTRASUA;Integrated Security=True";
            conn = new SqlConnection(connString);
            comm = conn.CreateCommand();
        }
        public static DALConnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DALConnect();
                }
                return instance;
            }
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct)
        {
            bool f = false;

            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
