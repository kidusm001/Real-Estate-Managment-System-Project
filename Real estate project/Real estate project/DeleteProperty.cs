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
    public partial class DeleteProperty : Form
    {
        public DeleteProperty()
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

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            int uId = int.Parse(txtPropertyId.Text);
            Property a = new Property();
            try
            {
                int rowsAffected = a.delete(uId);
                if (rowsAffected > 0)
                    MessageBox.Show("delete Complete");
                else
                    MessageBox.Show("delete Failed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnDeletePropFromSells_Click(object sender, EventArgs e)
        {
            int uId = int.Parse(txtPropertyId.Text);
            Property a = new Property();
            try
            {
                int rowsAffected = a.deletePropertForSell(uId);
                if (rowsAffected > 0)
                    MessageBox.Show("delete Complete");
                else
                    MessageBox.Show("delete Failed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
