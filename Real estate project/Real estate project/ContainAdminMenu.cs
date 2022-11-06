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
    public partial class ContainAdminMenu : Form
    {
        public ContainAdminMenu()
        {
            InitializeComponent();
        }

        private void ContainAdminMenu_Load(object sender, EventArgs e)
        {
            AdminMenuPage a = new AdminMenuPage();
            a.Dock = DockStyle.Fill;
            a.Parent = this;
            a.Show();
        }
    }
}
