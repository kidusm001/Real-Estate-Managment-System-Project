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
    public partial class DeletePropertyType : Form
    {
        public DeletePropertyType()
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

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(txtTypeId.Text);
            PropertyType a = new PropertyType()
            ;
            try
            {
                int rowsAffected = a.deletePropertyType(uid);
                if (rowsAffected > 0)
                    MessageBox.Show("Delete Complete");
                else
                    MessageBox.Show("Delete Failed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
