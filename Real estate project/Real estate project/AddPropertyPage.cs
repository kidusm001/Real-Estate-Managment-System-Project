using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_estate_project
{
    public partial class AddPropertyPage : Form
    {
        public AddPropertyPage()
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

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            bool isVal = true;
            Regex regex = new Regex(@"^[a-z]{2}$");
            errorProvider_ps.Clear();
            errorProvider_pti.Clear();
            errorProvider_oi.Clear();
            errorProvider_cn.Clear();
            errorProvider_rn.Clear();
            errorProvider_zn.Clear();
            errorProvider_wn.Clear();
            errorProvider_sn.Clear();
            if (string.IsNullOrEmpty(txtPropertySize.Text))
            {
                isVal = false;
                errorProvider_ps.SetError(txtPropertySize, "size is Required");
            }
            else
                errorProvider_ps.Clear();
            if (string.IsNullOrEmpty(txtTypeId.Text))
            {
                isVal = false;
                errorProvider_pti.SetError(txtTypeId, "size is Required");
            }
            else
                errorProvider_pti.Clear();
            if (string.IsNullOrEmpty(txtOwnerId.Text))
            {
                isVal = false;
                errorProvider_oi.SetError(txtOwnerId, "size is Required");
            }
            else
                errorProvider_oi.Clear();
            if (string.IsNullOrEmpty(txtCountryName.Text))
            {
                isVal = false;
                errorProvider_cn.SetError(txtCountryName, "size is Required");
            }
            else
                errorProvider_cn.Clear();
            if (string.IsNullOrEmpty(txtRegionName.Text))
            {
                isVal = false;
                errorProvider_rn.SetError(txtRegionName, "size is Required");
            }
            else
                errorProvider_rn.Clear();
            if (string.IsNullOrEmpty(txtZoneName.Text))
            {
                isVal = false;
                errorProvider_zn.SetError(txtZoneName, "size is Required");
            }
            else
                errorProvider_zn.Clear();
            if (string.IsNullOrEmpty(txtStreetName.Text))
            {
                isVal = false;
                errorProvider_sn.SetError(txtStreetName, "size is Required");
            }
            else
                errorProvider_sn.Clear();
            if (string.IsNullOrEmpty(txtWoredaName.Text))
            {
                isVal = false;
                errorProvider_wn.SetError(txtWoredaName, "size is Required");
            }
            else
                errorProvider_wn.Clear();

            if (isVal)
            {
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
                    int rowsAffected = a.save();
                    if (rowsAffected > 0)
                        MessageBox.Show("Register Complete");
                    else
                        MessageBox.Show("Registration Failed");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void txtWoredaName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
