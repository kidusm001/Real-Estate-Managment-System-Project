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
    public partial class UpdateAgentForAdmin : Form
    {
        public UpdateAgentForAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddClientPage_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            txtCommissionPer.ForeColor = Color.Silver;
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

        private void txtCommissionPer_Enter(object sender, EventArgs e)
        {
            if (txtCommissionPer.Text == "0-100%")
            {
                txtCommissionPer.Text = "";
                txtCommissionPer.ForeColor = Color.Black;
            }
        }

        private void txtCommissionPer_Leave(object sender, EventArgs e)
        {
            if (txtCommissionPer.Text == "")
            {
                txtCommissionPer.Text = "0-100%";
                txtCommissionPer.ForeColor = Color.Silver;
            }
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(txtAgentId.Text);
            txtPassword.UseSystemPasswordChar = true;
            Agent a = new Agent
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                CommissionPercent=double.Parse(txtCommissionPer.Text),
                HomephoneNumber = txtHomePhonenum.Text,
                MobilephoneNumber = txtMobilePhonenum.Text
            };
            try
            {
                int rowsAffected = a.updateForAdmin(uid);
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
