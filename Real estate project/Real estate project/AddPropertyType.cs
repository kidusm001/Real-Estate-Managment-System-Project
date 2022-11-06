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
    public partial class AddPropertyType : Form
    {
        public AddPropertyType()
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

        private void btnAddType_Click(object sender, EventArgs e)
        {
            PropertyType a = new PropertyType
            {
                TypeName = txtTypeName.Text
            };
            try
            {
                int rowsAffected = a.savePropertyType();
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
}
