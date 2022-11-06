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
    public partial class UpdateProductTab : Form
    {
        public UpdateProductTab()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == UpdateProp)
            {
                UpdatePropertyPage s = new UpdatePropertyPage();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.UpdateProp.Controls.Add(s);
                this.UpdateProp.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == UpdatePropSellList)
            {
                UpdatePropertyToSellList s = new UpdatePropertyToSellList();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.UpdatePropSellList.Controls.Add(s);
                this.UpdatePropSellList.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == UpdatePropSellListAgent)
            {
                UpdatePropertyToSellListAgent s = new UpdatePropertyToSellListAgent();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.UpdatePropSellListAgent.Controls.Add(s);
                this.UpdatePropSellListAgent.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == UpdatePropSellListOwner)
            {
                UpdatePropertyToSellListOwner s = new UpdatePropertyToSellListOwner();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.UpdatePropSellListOwner.Controls.Add(s);
                this.UpdatePropSellListOwner.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == UpdatePropType)
            {
                UpdatePropertyType s = new UpdatePropertyType();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.UpdatePropType.Controls.Add(s);
                this.UpdatePropType.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == UpdateSoldProp)
            {
                UpdateSoldPropertyPage s = new UpdateSoldPropertyPage();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.UpdateSoldProp.Controls.Add(s);
                this.UpdateSoldProp.Tag = s;
                s.Show();
            }
        }
    }
}
