using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Real_estate_managment_system
{
    class DBService
    {
        string path = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        SqlConnection conn;
        public SqlConnection connect()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = path;
                if(conn.State== System.Data.ConnectionState.Closed)
                conn.Open();
                //MessageBox.Show("Connection is successful !");
                return conn;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void closeconnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        
    }
}
