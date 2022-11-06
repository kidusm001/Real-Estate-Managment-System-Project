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
    public partial class DeletePropertyTab : Form
    {
        public DeletePropertyTab()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == DeleteProp)
            {
                DeleteProperty s = new DeleteProperty();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.DeleteProp.Controls.Add(s);
                this.DeleteProp.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == DeletePropType)
            {
                DeletePropertyType s = new DeletePropertyType();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.DeletePropType.Controls.Add(s);
                this.DeletePropType.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == DeleteSoldProp)
            {
                DeleteSoldProperty s = new DeleteSoldProperty();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.DeleteSoldProp.Controls.Add(s);
                this.DeleteSoldProp.Tag = s;
                s.Show();
            }
        }
    }
}
