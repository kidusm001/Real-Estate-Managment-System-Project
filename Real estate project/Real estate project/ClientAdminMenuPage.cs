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
    public partial class ClientAdminMenuPage : Form
    {
        public ClientAdminMenuPage()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel2.Controls.Count > 0)
            {
                this.mainpanel2.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            this.mainpanel2.Controls.Add(f);
            this.mainpanel2.Tag = f;
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClientPage a = new AddClientPage();
            a.FormBorderStyle = FormBorderStyle.None;
            loadform(a);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            loadform(new UpdateClientForAdmin());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loadform(new DeleteClient());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadform(new ShowClients());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadform(new SearchClient());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Show();
        }
    }
}
