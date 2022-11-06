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
    public partial class AddPropertyTab : Form
    {
        public AddPropertyTab()
        {
            InitializeComponent();
        }
       
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == AddProperty)
            {
                AddPropertyPage s = new AddPropertyPage();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.AddProperty.Controls.Add(s);
                this.AddProperty.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == AddPropToSellList)
            {
                AddPropertyToSellList s = new AddPropertyToSellList();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.AddPropToSellList.Controls.Add(s);
                this.AddPropToSellList.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == AddPropertyType)
            {
                AddPropertyType s = new AddPropertyType();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.AddPropertyType.Controls.Add(s);
                this.AddPropertyType.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == AddSoldProperty)
            {
                AddSoldPropertyPage s = new AddSoldPropertyPage();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.AddSoldProperty.Controls.Add(s);
                this.AddSoldProperty.Tag = s;
                s.Show();
            }
        }
    }
}
