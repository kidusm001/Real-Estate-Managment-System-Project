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
    public partial class AgentMainPage : Form
    {
        public AgentMainPage()
        {
            InitializeComponent();
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            
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
            f.AutoScroll = true;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            loadform(new ClientAdminMenuPage());
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            loadform(new PropertyAdminMenuPage());
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            loadform(new AgentAdminMenuPage());
        }
    }
}
