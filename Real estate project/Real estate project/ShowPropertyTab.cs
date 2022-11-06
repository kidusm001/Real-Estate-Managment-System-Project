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
    public partial class ShowPropertyTab : Form
    {
        public ShowPropertyTab()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == ShowProp)
            {
                ShowProperty s = new ShowProperty();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.ShowProp.Controls.Add(s);
                this.ShowProp.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == ShowProptobeSold)
            {
                ShowPropertytobeSold s = new ShowPropertytobeSold();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.ShowProptobeSold.Controls.Add(s);
                this.ShowProptobeSold.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == ShowPropByAgent)
            {
                ShowPropertytobeSoldbyAgent s = new ShowPropertytobeSoldbyAgent();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.ShowPropByAgent.Controls.Add(s);
                this.ShowPropByAgent.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == ShowPropByOwner)
            {
                ShowPropertytobeSoldbyOwner s = new ShowPropertytobeSoldbyOwner();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.ShowPropByOwner.Controls.Add(s);
                this.ShowPropByOwner.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == ShowPropType)
            {
                ShowPropertyType s = new ShowPropertyType();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.ShowPropType.Controls.Add(s);
                this.ShowPropType.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == ShowSoldProp)
            {
                ShowSoldProperty s = new ShowSoldProperty();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.ShowSoldProp.Controls.Add(s);
                this.ShowSoldProp.Tag = s;
                s.Show();
            }
        }
    }
}
