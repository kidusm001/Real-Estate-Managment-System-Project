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
    public partial class SearchProperty : Form
    {
        public SearchProperty()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddClientPage_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            
        }

        private void btnSearchProperty_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(txtPropertyId.Text);
            Property a = Property.findProperty(uid);
            PropertyCard p = new PropertyCard();
            p.Id = a.PropertyId.ToString();
            p.PropertySize = a.PropertySize.ToString();
            p.PropertyType = a.TypeName;
            p.OwnerId = a.OwnerId.ToString();
            p.StreetName = a.StreetName;
            p.WoredaName = a.WoredaName;
            p.ZoneName = a.ZoneName;
            p.RegionName = a.RegionName;
            p.countryName = a.countryName;
            p.Dock = DockStyle.Bottom;
            panel1.Controls.Add(p);
        }
    }
}
