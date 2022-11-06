using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_estate_project
{
    public partial class Login : Form
    {
        public static Login instance;
        public int uId;
        public Login()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            btnShowPassword.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ForeColor = Color.Silver;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnHidePassword.BringToFront();
        }

        
        private void btnHidePassword_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnShowPassword.BringToFront();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text=="Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text=="User Name")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "User Name";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            txtPassword.UseSystemPasswordChar = false;
            password = txtPassword.Text;
            bool isVal = true;
            try
            {
                Regex regex = new Regex(@"^[a-z]{2}$");
                errorProviderName.Clear();
                errorProviderPass.Clear();
                if (regex.IsMatch(txtUsername.Text))
                {
                    isVal = false;
                    errorProviderName.SetError(txtUsername, "2 digit name");
                }
                if (regex.IsMatch(txtUsername.Text))
                {
                    isVal = false;
                    errorProviderName.SetError(txtUsername, "User Name is Requiered");
                }
                else
                    errorProviderName.Clear();
                if (regex.IsMatch(txtPassword.Text))
                {
                    isVal = false;
                    errorProviderName.SetError(txtPassword, "2 digit Password");
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    isVal = false;
                    errorProviderPass.SetError(txtPassword, "Password is Required");
                }
                else
                    errorProviderPass.Clear();
                if (isVal)
                {
                    string query = "SELECT * FROM tblClient WHERE username = '" + txtUsername.Text + "' AND _password ='" + txtPassword.Text + "'";
                    DBService db = new DBService();
                    SqlCommand cmd = new SqlCommand(query, db.connect());
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Person p = new Person
                        {

                            UserName = dr["username"].ToString(),
                            Password = dr["_password"].ToString()

                        };
                        uId = int.Parse(dr["clientId"].ToString());
                        if (p.UserName == username && p.Password == password)
                        {
                            ClientMainPage c = new ClientMainPage();
                            this.Hide();
                            c.Show();

                            //break;


                        }
                    }
                
                }
                
                

            }
            catch (SqlException ee)
            {
                MessageBox.Show("Account does not exist\n"+ee);

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            AddClientPage c = new AddClientPage();
            this.Hide();
            c.Show();
            
        }

        private void signInAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            txtPassword.UseSystemPasswordChar = false;
            password = txtPassword.Text;
            try
            {
                string query = "SELECT * FROM tblAgent WHERE username = '" + txtUsername.Text + "' AND _password ='" + txtPassword.Text + "'";
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Person p = new Person
                    {
                        UserName = dr["username"].ToString(),
                        Password = dr["_password"].ToString()

                    };
                    uId = int.Parse(dr["agentId"].ToString());
                    if (p.UserName == username && p.Password == password)
                    {
                        AgentMainPage c = new AgentMainPage();
                        this.Hide();
                        c.Show();

                        //break;


                    }
                }



            }
            catch (SqlException ee)
            {
                MessageBox.Show("Account does not exist\n" + ee);

            }
        }

        private void signInAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            txtPassword.UseSystemPasswordChar = false;
            password = txtPassword.Text;
            try
            {
                string query = "SELECT * FROM tblAdmin WHERE username = '" + txtUsername.Text + "' AND _password ='" + txtPassword.Text + "'";
                DBService db = new DBService();
                SqlCommand cmd = new SqlCommand(query, db.connect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Person p = new Person
                    {
                        UserName = dr["username"].ToString(),
                        Password = dr["_password"].ToString()

                    };
                    if (p.UserName == username && p.Password == password)
                    {
                        AdminMainPage c = new AdminMainPage();
                        this.Hide();
                        c.Show();

                        //break;


                    }
                }



            }
            catch (SqlException ee)
            {
                MessageBox.Show("Account does not exist\n" + ee);

            }
        }
    }
}
