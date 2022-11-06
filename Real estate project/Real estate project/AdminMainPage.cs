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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            btnAdmin.Parent = pictureBox1;
            btnAdmin.BackColor = Color.Transparent;
            btnAgent.Parent = pictureBox1;
            btnAgent.BackColor = Color.Transparent;
            btnClient.Parent = pictureBox1;
            btnClient.BackColor = Color.Transparent;
            btnProperty.Parent = pictureBox1;
            btnProperty.BackColor = Color.Transparent;
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
                
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminMenuPage a = new AdminMenuPage();
            loadform(a);
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            loadform(new AgentAdminMenuPage());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            loadform(new ClientAdminMenuPage());
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            loadform(new PropertyAdminMenuPage());
        }
    }
}
