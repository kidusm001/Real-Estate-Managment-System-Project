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
    public partial class SearchPropertyTab : Form
    {
        public SearchPropertyTab()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == SearchProp)
            {
                SearchProperty s = new SearchProperty();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.SearchProp.Controls.Add(s);
                this.SearchProp.Tag = s;
                s.Show();
            }
            if (tabControl1.SelectedTab == SearchSoldProp)
            {
                SearchSoldPropertyByTrans s = new SearchSoldPropertyByTrans();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                s.AutoScroll = true;
                this.SearchSoldProp.Controls.Add(s);
                this.SearchSoldProp.Tag = s;
                s.Show();
            }
        }
    }
}
