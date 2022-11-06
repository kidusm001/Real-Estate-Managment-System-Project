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
    class Admin : Person
    {
        public static List<Admin> admins = new List<Admin>();
        public int save()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spAddAdmin @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = this.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = this.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("@phonenumber1", SqlDbType.VarChar).Value = this.HomephoneNumber;
                cmd.Parameters.Add("@phonenumber2", SqlDbType.VarChar).Value = this.MobilephoneNumber;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                admins.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int update(int uid)
        {
            try
            {
                
                DBService db = new DBService();
                string query = "EXEC spUpdateAdmin @adminId, @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@adminId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = this.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = this.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("@phonenumber1", SqlDbType.VarChar).Value = this.HomephoneNumber;
                cmd.Parameters.Add("@phonenumber2", SqlDbType.VarChar).Value = this.MobilephoneNumber;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                admins.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int delete(int uid)
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spDeleteAdmin @adminId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@adminId", SqlDbType.Int).Value = uid;
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
        public DataTable getAll()
        {
            string query = "SELECT * FROM udfGetAllAdmin()";
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
        public static List<Admin> getAllByName()
        {
            string query = "EXEC spDisplayByAdminName";
            try
            {
                admins.Clear();
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Admin a = new Admin();
                    a.Id = (int)result["adminId"];
                    a.FirstName = (string)result["firstName"];
                    a.LastName = (string)result["lastName"];
                    a.Email = (string)result["email"];
                    a.UserName = (string)result["username"];
                    a.HomephoneNumber = (string)result["Home"];
                    a.MobilephoneNumber = (string)result["Mobile"];
                    admins.Add(a);

                }
                db.closeconnection();
                return admins;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static Admin findAdmin(string uName)
        {
            DBService db = new DBService();
            string name = uName;
            string query = "EXEC spSearchAdminByusername '"+name+ "'";
            SqlCommand cmd = new SqlCommand(query, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Admin admin = new Admin();
                while (dr.Read())
                {
                    admin.Id = int.Parse(dr.GetValue(0).ToString());
                    admin.FirstName = dr.GetValue(1).ToString();
                    admin.LastName = dr.GetValue(2).ToString();
                    admin.Email = dr.GetValue(3).ToString();
                    admin.UserName = dr.GetValue(4).ToString();
                    admin.HomephoneNumber = dr.GetValue(5).ToString();
                    admin.MobilephoneNumber = dr.GetValue(6).ToString();
                }
                db.closeconnection();
                return admin;
            }
            else
                return null;
        }
    }
}
