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
    public partial class UpdatePropertyToSellListOwner : Form
    {
        public UpdatePropertyToSellListOwner()
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
            Property a = new Property
            {
                PropertyId = int.Parse(txtPropertyId.Text),

                OwnerId = int.Parse(txtOwnerId.Text)
            };
            try
            {
                int rowsAffected = a.updateOwneronForSell(a.OwnerId, a.PropertyId);
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
