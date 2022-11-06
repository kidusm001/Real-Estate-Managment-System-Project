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
    public partial class ShowAdmins : Form
    {
        public ShowAdmins()
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

        private void btnShowbyId_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            try
            {
                DisplayAdminView.DataSource = null;
                DisplayAdminView.DataSource= a.getAll();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void btnShowbyName_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            try
            {
                DisplayAdminView.DataSource = null;
                DisplayAdminView.DataSource = Admin.getAllByName();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
    }
}
