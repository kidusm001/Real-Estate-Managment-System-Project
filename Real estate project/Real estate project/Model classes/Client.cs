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
    class Client : Person
    {
        public static List<Client> clients = new List<Client>();
        public int save()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spAddClient @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2";
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
                clients.Add(this);
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
                string query = "EXEC spUpdateClient @clientId, @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@clientId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = this.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = this.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("@phonenumber1", SqlDbType.VarChar).Value = this.HomephoneNumber;
                cmd.Parameters.Add("@phonenumber2", SqlDbType.VarChar).Value = this.MobilephoneNumber;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                clients.Add(this);
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
                string query = "EXEC spDeleteClient @clientId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@clientId", SqlDbType.Int).Value = uid;
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
            string query = "SELECT * FROM udfGetAllClient()";
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
        public static List<Client> getAllByName()
        {
            string query = "EXEC spDisplayByClientName";
            try
            {
                clients.Clear();
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Client a = new Client();
                    a.Id = (int)result["clientId"];
                    a.FirstName = (string)result["firstName"];
                    a.LastName = (string)result["lastName"];
                    a.Email = (string)result["email"];
                    a.UserName = (string)result["username"];
                    a.HomephoneNumber = (string)result["Home"];
                    a.MobilephoneNumber = (string)result["Mobile"];
                    clients.Add(a);

                }
                db.closeconnection();
                return clients;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static Client findClient(string uName)
        {
            DBService db = new DBService();
            string name = uName;
            string query = "EXEC spSearchClientByusername '" + name + "'";
            SqlCommand cmd = new SqlCommand(query, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Client client = new Client();
                while (dr.Read())
                {
                    client.Id = int.Parse(dr.GetValue(0).ToString());
                    client.FirstName = dr.GetValue(1).ToString();
                    client.LastName = dr.GetValue(2).ToString();
                    client.Email = dr.GetValue(3).ToString();
                    client.UserName = dr.GetValue(4).ToString();
                    client.HomephoneNumber = dr.GetValue(5).ToString();
                    client.MobilephoneNumber = dr.GetValue(6).ToString();
                }
                db.closeconnection();
                return client;
            }
            else
                return null;
        }
    }
}
