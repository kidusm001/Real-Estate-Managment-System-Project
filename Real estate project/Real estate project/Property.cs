using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Real_estate_project
{
    class Property : PropertyType
    {
        public static List<Property> propertys = new List<Property>();
        public int PropertyId { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public double PropertySize { get; set; }
        public int OwnerId { get; set; }
        public int AgentId { get; set; }
        public string OwnerName { get; set; }
        public string AgentName { get; set; }
        public int countryId { get; set; }
        public string countryName { get; set; }
        public int RegionId { get; set; }
        public int ZoneId { get; set; }
        public int WoredaId { get; set; }
        public int StreetId { get; set; }
        public string RegionName { get; set; }
        public string ZoneName { get; set; }
        public string WoredaName { get; set; }
        public string StreetName { get; set; }
        public string BuyerName { get; set; }
        public string SellerName { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public DateTime DateSold { get; set; }
        public int TransactionId { get; set; }
        public int save()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spAddProperty @propertySize,@typeId,@ownerId,@countryName,@regionName,@zoneName,@woredaName,@streetName";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertySize", SqlDbType.Decimal).Value = this.PropertySize;
                cmd.Parameters.Add("@typeId", SqlDbType.Int).Value = this.TypeId;
                cmd.Parameters.Add("@ownerId", SqlDbType.Int).Value = this.OwnerId;
                cmd.Parameters.Add("@countryName", SqlDbType.VarChar).Value = this.countryName;
                cmd.Parameters.Add("@regionName", SqlDbType.VarChar).Value = this.RegionName;
                cmd.Parameters.Add("@zoneName", SqlDbType.VarChar).Value = this.ZoneName;
                cmd.Parameters.Add("@woredaName", SqlDbType.VarChar).Value = this.WoredaName;
                cmd.Parameters.Add("@streetName", SqlDbType.VarChar).Value = this.StreetName;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
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
                string query = "EXEC spUpdateProperty @propertyId,@propertySize,@typeId,@ownerId,@countryName,@regionName,@zoneName,@woredaName,@streetName";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = uid;
                cmd.Parameters.Add("@propertySize", SqlDbType.Decimal).Value = this.PropertySize;
                cmd.Parameters.Add("@typeId", SqlDbType.Int).Value = this.TypeId;
                cmd.Parameters.Add("@ownerId", SqlDbType.Int).Value = this.OwnerId;
                cmd.Parameters.Add("@countryName", SqlDbType.VarChar).Value = this.countryName;
                cmd.Parameters.Add("@regionName", SqlDbType.VarChar).Value = this.RegionName;
                cmd.Parameters.Add("@zoneName", SqlDbType.VarChar).Value = this.ZoneName;
                cmd.Parameters.Add("@woredaName", SqlDbType.VarChar).Value = this.WoredaName;
                cmd.Parameters.Add("@streetName", SqlDbType.VarChar).Value = this.StreetName;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
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
                string query = "EXEC spDeleteProperty @propertyId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = uid;
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
        public int deletePropertForSell(int uid)
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spDeletePropertForSell @propertyId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = uid;
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
            string query = "SELECT * FROM udfGetAllProperty()";
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
        public static Property findProperty(int propID)
        {
            DBService db = new DBService();
            int id = propID;
            string query = "EXEC spSearchPropertyByPropertyId " + id + "";
            SqlCommand cmd = new SqlCommand(query, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Property property = new Property();
                while (dr.Read())
                {
                    property.PropertyId = int.Parse(dr.GetValue(0).ToString());
                    property.PropertySize = double.Parse(dr.GetValue(1).ToString());
                    property.TypeName = dr.GetValue(2).ToString();
                    property.OwnerName = dr.GetValue(3).ToString();
                    property.StreetName = dr.GetValue(4).ToString();
                    property.WoredaName = dr.GetValue(5).ToString();
                    property.ZoneName = dr.GetValue(6).ToString();
                    property.RegionName = dr.GetValue(7).ToString();
                    property.countryName = dr.GetValue(8).ToString();
                }
                db.closeconnection();
                return property;
            }
            else
                return null;
        }
        public static List<Property> getByPropertyType(string uName)
        {
            string name = uName;
            string query = "EXEC spSearchByPropertyType '" + name + "'";
            try
            {
                propertys.Clear();
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Property a = new Property();
                    a.PropertyId = int.Parse(result["propertyId"].ToString());
                    a.PropertySize = double.Parse(result["propertySize"].ToString());
                    a.TypeName = (string)result["typeName"];
                    a.OwnerName = (string)result["Owner Name"];
                    a.StreetName = (string)result["Street Name"];
                    a.WoredaName = (string)result["WoredaName"];
                    a.ZoneName = (string)result["Zone Name"];
                    a.RegionName = (string)result["Region Name"];
                    a.countryName = (string)result["country Name"];
                    
                    propertys.Add(a);

                }
                db.closeconnection();
                return propertys;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public int AddtoListforSell()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spListForSell @propertyId,@isAvailable,@price,@ownerId,@agentId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = this.PropertyId;
                cmd.Parameters.Add("@isAvailable", SqlDbType.Bit).Value = this.IsAvailable;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = this.Price;
                cmd.Parameters.Add("@ownerId", SqlDbType.Int).Value = this.OwnerId;
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = this.AgentId;
                
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int UpdateforSell()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spUpdateForSell @propertyId,@isAvailable,@price,@ownerId,@agentId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = this.PropertyId;
                cmd.Parameters.Add("@isAvailable", SqlDbType.Bit).Value = this.IsAvailable;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = this.Price;
                cmd.Parameters.Add("@ownerId", SqlDbType.Int).Value = this.OwnerId;
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = this.AgentId;

                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updateAgentonForSell(int aid,int pid)
        {
            try
            {

                DBService db = new DBService();
                string query = "EXEC spUpdateAgentonForSell @agentId,@propertyId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = aid;
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = pid;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updateOwneronForSell(int aid, int pid)
        {
            try
            {

                DBService db = new DBService();
                string query = "EXEC spUpdateOwneronForSell @ownerId,@propertyId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@ownerId", SqlDbType.Int).Value = aid;
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = pid;
                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public DataTable getAllForSell()
        {
            string query = "SELECT * FROM udfGetAllPropertyForSell()";
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
        public static List<Property> getPropertytoBeSoldByAgent(int aid)
        {
            
            string query = "EXEC spPropertytoBeSoldByAgent " + aid + "";
            try
            {
                propertys.Clear();
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Property a = new Property();
                    a.PropertyId = int.Parse(result["propertyId"].ToString());
                    a.PropertySize = double.Parse(result["propertySize"].ToString());
                    a.TypeName = (string)result["typeName"];
                    a.OwnerName = (string)result["Owner Name"];
                    a.StreetName = (string)result["Street Name"];
                    a.WoredaName = (string)result["WoredaName"];
                    a.ZoneName = (string)result["Zone Name"];
                    a.RegionName = (string)result["Region Name"];
                    a.countryName = (string)result["country Name"];
                    a.Price = double.Parse(result["price"].ToString());
                    a.IsAvailable = (bool)result["isAvailable"];
                    propertys.Add(a);

                }
                db.closeconnection();
                return propertys;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<Property> getPropertytoBeSoldByOwner(int aid)
        {

            string query = "EXEC spPropertytoBeSoldByOwner " + aid + "";
            try
            {
                propertys.Clear();
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Property a = new Property();
                    a.PropertyId = (int)result["propertyId"];
                    a.PropertySize = (double)result["propertySize"];
                    a.TypeName = (string)result["typeName"];
                    a.OwnerName = (string)result["Owner Name"];
                    a.StreetName = (string)result["Street Name"];
                    a.WoredaName = (string)result["WoredaName"];
                    a.ZoneName = (string)result["Zone Name"];
                    a.RegionName = (string)result["Region Name"];
                    a.countryName = (string)result["country Name"];
                    a.Price = (double)result["price"];
                    a.IsAvailable = (bool)result["isAvailable"];
                    a.AgentName = (string)result["Agent Name"];
                    propertys.Add(a);

                }
                db.closeconnection();
                return propertys;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public int AddSoldProperty()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spAddSoldProperty @propertyId,@sellerId,@buyerId,@dateSold,@agentId,@price";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = this.PropertyId;
                cmd.Parameters.Add("@sellerId", SqlDbType.Int).Value = this.SellerId;
                cmd.Parameters.Add("@buyerId", SqlDbType.Int).Value = this.BuyerId;
                cmd.Parameters.Add("@dateSold", SqlDbType.DateTime).Value = this.DateSold;
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = this.AgentId;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = this.Price;
                
                

                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int updateSoldProperty()
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spUpdateSoldProperty @transactionId,@propertyId,@sellerId,@buyerId,@dateSold,@agentId,@price";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@transactionId", SqlDbType.Int).Value = this.TransactionId;
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = this.PropertyId;
                cmd.Parameters.Add("@sellerId", SqlDbType.Int).Value = this.SellerId;
                cmd.Parameters.Add("@buyerId", SqlDbType.Int).Value = this.BuyerId;
                cmd.Parameters.Add("@dateSold", SqlDbType.DateTime).Value = this.DateSold;
                cmd.Parameters.Add("@agentId", SqlDbType.Int).Value = this.AgentId;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = this.Price;



                int rowAff = cmd.ExecuteNonQuery();
                db.closeconnection();
                propertys.Add(this);
                return rowAff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int DeleteSoldProperty(int tid)
        {
            try
            {
                DBService db = new DBService();
                string query = "EXEC spDeleteSoldProperty @transactionId";
                SqlCommand cmd = new SqlCommand(query, db.connect());
                cmd.Parameters.Add("@propertyId", SqlDbType.Int).Value = tid;
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
        public DataTable getAllSoldProperty()
        {
            string query = "EXEC spDisplayAllSoldProperty";
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
        public static Property findTransaction(int tranID)
        {
            DBService db = new DBService();
            int id = tranID;
            string query = "EXEC spSearchTransaction " + id + "";
            SqlCommand cmd = new SqlCommand(query, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Property property = new Property();
                while (dr.Read())
                {
                    property.TransactionId = int.Parse(dr.GetValue(0).ToString());
                    property.PropertyId = int.Parse(dr.GetValue(1).ToString());
                    property.SellerName = dr.GetValue(2).ToString();
                    property.BuyerName = dr.GetValue(3).ToString();
                    property.DateSold = DateTime.Parse(dr.GetValue(4).ToString());
                    property.AgentName = dr.GetValue(5).ToString();
                    property.Price = double.Parse(dr.GetValue(6).ToString());
                    
                }
                db.closeconnection();
                return property;
            }
            else
                return null;
        }
    }
}
