using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Real_estate_managment_system
{
    class PropertyType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public static List<PropertyType> ptypes = new List<PropertyType>();
        public int savePropertyType()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spAddPropertyType @typeName";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@typeName", SqlDbType.VarChar).Value = this.TypeName;
                
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                ptypes.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updatePropertyType(int uid)
        {
            try
            {

                DBService db = new DBService();
                string query = "EXEC spUpdatePropertyType @typeId, @typeName";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@typeId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@typeName", SqlDbType.VarChar).Value = this.TypeName;
                
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                ptypes.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int deletePropertyType(int uid)
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spDeletePropertyType @typeId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@typeId", SqlDbType.Int).Value = uid;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                return rowAff;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public DataTable getAllPropertyType()
        {
            string query = "EXEC spDisplayAllTypes";
            try
            {
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeconnection();
                return table;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        

    }
}
