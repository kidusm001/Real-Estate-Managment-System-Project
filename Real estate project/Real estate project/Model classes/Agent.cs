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
    class Agent : Person
    {
        public static List<Agent> agents = new List<Agent>();
        public double TotalCommission { get; set; }
        public double CommissionPercent { get; set; }
        public int save()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spAddAgent @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2,@commissionPercent";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = this.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = this.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("@phonenumber1", SqlDbType.VarChar).Value = this.HomephoneNumber;
                cmd.Parameters.Add("@phonenumber2", SqlDbType.VarChar).Value = this.MobilephoneNumber;
                cmd.Parameters.Add("@commissionPercent", SqlDbType.Decimal).Value = this.CommissionPercent;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                agents.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updateForAgent(int uid)
        {
            try
            {

                DBService db = new DBService();
                string query = "EXEC spUpdateAgentForAgent @agentId, @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = this.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = this.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("@phonenumber1", SqlDbType.VarChar).Value = this.HomephoneNumber;
                cmd.Parameters.Add("@phonenumber2", SqlDbType.VarChar).Value = this.MobilephoneNumber;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                agents.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updateForAdmin(int uid)
        {
            try
            {

                DBService db = new DBService();
                string query = "EXEC spUpdateAgentForAdmin @agentId, @Fname,@Lname,@Email,@Username,@password,@phonenumber1,@phonenumber2,@commissionPercent";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = this.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = this.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("@phonenumber1", SqlDbType.VarChar).Value = this.HomephoneNumber;
                cmd.Parameters.Add("@phonenumber2", SqlDbType.VarChar).Value = this.MobilephoneNumber;
                cmd.Parameters.Add("@commissionPercent", SqlDbType.Decimal).Value = this.CommissionPercent;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                agents.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updateAgentcommissionPercent(int uid,double _commissionPercent)
        {
            try
            {

                DBService db = new DBService();
                string query = "EXEC spUpdateAgentcommissionPercent @agentId,@commissionPercent";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@commissionPercent", SqlDbType.Decimal).Value = _commissionPercent;
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
        public int delete(int uid)
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spDeleteAgent @agentId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = uid;
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
            string query = "SELECT * FROM udfGetAllAgent()";
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
        public static List<Agent> getAllByCommission()
        {
            string query = "EXEC spDisplayAgentsByCommission";
            try
            {
                agents.Clear();
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Agent a = new Agent();
                    a.Id = (int)result["agentId"];
                    a.FirstName = (string)result["firstName"];
                    a.LastName = (string)result["lastName"];
                    a.Email = (string)result["email"];
                    a.UserName = (string)result["username"];
                    a.HomephoneNumber = (string)result["Home"];
                    a.MobilephoneNumber = (string)result["Mobile"];
                    a.TotalCommission = (double)result["Total Commissions"];
                    a.CommissionPercent = (double)result["Commission percent"];
                    agents.Add(a);

                }
                db.closeconnection();
                return agents;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static Agent findAgent(string uName)
        {
            DBService db = new DBService();
            string name = uName;
            string query = "EXEC spSearchAgentByusername '" + name + "'";
            SqlCommand cmd = new SqlCommand(query, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Agent agent = new Agent();
                while (dr.Read())
                {
                    agent.Id = int.Parse(dr.GetValue(0).ToString());
                    agent.FirstName = dr.GetValue(1).ToString();
                    agent.LastName = dr.GetValue(2).ToString();
                    agent.Email = dr.GetValue(3).ToString();
                    agent.UserName = dr.GetValue(4).ToString();
                    agent.HomephoneNumber = dr.GetValue(5).ToString();
                    agent.MobilephoneNumber = dr.GetValue(6).ToString();
                    agent.TotalCommission = double.Parse(dr.GetValue(7).ToString());
                    agent.CommissionPercent = double.Parse(dr.GetValue(8).ToString());
                }
                db.closeconnection();
                return agent;
            }
            else
                return null;
        }
    }
}
