using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_estate_project
{
    public partial class AddClientPage : Form
    {
        public AddClientPage()
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {

            bool isVal = true;
            Regex regex = new Regex(@"^[a-z]{2}$");
            errorProvider_FN.Clear();
            errorProvider_ln.Clear();
            errorProvider_e.Clear();
            errorProvider_un.Clear();
            errorProvider_p.Clear();
            errorProvider_hpn.Clear();
            errorProvider_mpn.Clear();
            if (regex.IsMatch(txtFirstName.Text))
            {
                isVal = false;
                errorProvider_FN.SetError(txtFirstName, "2 digit name");
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isVal = false;
                errorProvider_FN.SetError(txtFirstName, "Name is Required");
            }
            else
                errorProvider_FN.Clear();
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                isVal = false;
                errorProvider_ln.SetError(txtLastName, "Password is Required");
            }
            else
                errorProvider_ln.Clear();
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                isVal = false;
                errorProvider_e.SetError(txtEmail, "Password is Required");
            }
            else
                errorProvider_e.Clear();
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                isVal = false;
                errorProvider_un.SetError(txtUsername, "Password is Required");
            }
            else
                errorProvider_un.Clear();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                isVal = false;
                errorProvider_p.SetError(txtPassword, "Password is Required");
            }
            else
                errorProvider_p.Clear();
            if (string.IsNullOrEmpty(txtHomePhonenum.Text))
            {
                isVal = false;
                errorProvider_hpn.SetError(txtHomePhonenum, "Password is Required");
            }
            else
                errorProvider_hpn.Clear();
            if (string.IsNullOrEmpty(txtMobilePhonenum.Text))
            {
                isVal = false;
                errorProvider_mpn.SetError(txtMobilePhonenum, "Password is Required");
            }

            else
                errorProvider_mpn.Clear();
            if (isVal)
            {
                txtPassword.UseSystemPasswordChar = true;
                Client a = new Client
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
                    int rowsAffected = a.save();
                    if (rowsAffected > 0)
                        MessageBox.Show("Register Complete");
                    else
                        MessageBox.Show("Registration Failed");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Show();
        }
    }
}
