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
    public partial class AdminMenuPage : Form
    {
        public AdminMenuPage()
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
            this.mainpanel2.Controls.Add(f);
            this.mainpanel2.Tag = f;
            f.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            AddAdminPage screen = new AddAdminPage();
            //screen.MdiParent = this;
            screen.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            UpdateAdmin screen = new UpdateAdmin();
            screen.MdiParent = this;
            screen.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            DeleteAdmin screen = new DeleteAdmin();
            screen.MdiParent = this;
            screen.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            ShowAdmins screen = new ShowAdmins();
            screen.MdiParent = this;
            screen.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            SearchAdmin screen = new SearchAdmin();
            screen.MdiParent = this;
            screen.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login c = new Login();
            this.Hide();
            c.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            loadform(new AddAdminPage());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            loadform(new UpdateAdmin());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loadform(new DeleteAdmin());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadform(new ShowAdmins());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadform(new SearchAdmin());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Show();
        }
    }
}
