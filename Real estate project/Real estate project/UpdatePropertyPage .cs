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
    public partial class UpdatePropertyPage : Form
    {
        public UpdatePropertyPage()
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

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(txtPropertyId.Text);
            Property a = new Property
            {
                PropertySize = double.Parse(txtPropertySize.Text),
                TypeId = int.Parse(txtTypeId.Text),
                OwnerId = int.Parse(txtOwnerId.Text),
                countryName = txtCountryName.Text,
                RegionName = txtRegionName.Text,
                ZoneName = txtZoneName.Text,
                WoredaName = txtWoredaName.Text,
                StreetName = txtStreetName.Text
            };
            try
            {
                int rowsAffected = a.update(uid);
                if (rowsAffected > 0)
                    MessageBox.Show("Update Complete");
                else
                    MessageBox.Show("Update Failed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
