using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_estate_project
{
    public partial class UpdateClientForClient : Form
    {
        public int ids;
        public UpdateClientForClient()
        {
            InitializeComponent();
            ids = Login.instance.uId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddClientPage_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnHidePassword.BringToFront();
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnShowPassword.BringToFront();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            int uid = ids;
            txtPassword.UseSystemPasswordChar = true;
            Admin a = new Admin
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                HomephoneNumber = txtHomePhonenum.Text,
                MobilephoneNumber = txtMobilePhonenum.Text
            };
            try
            {
                int rowsAffected = a.update(uid);
                if (rowsAffected > 0)
                    MessageBox.Show("Update Complete");
                else
                    MessageBox.Show("Update Failed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
