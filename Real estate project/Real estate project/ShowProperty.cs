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
    public partial class ShowProperty : Form
    {
        public ShowProperty()
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

        private void btnShowbyId_Click(object sender, EventArgs e)
        {
            Property a = new Property();
            try
            {
                DisplayPropertyView.DataSource = null;
                DisplayPropertyView.DataSource = a.getAll();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void btnShowbyPropName_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            Property a = new Property();
            try
            {
                DisplayPropertyView.DataSource = null;
                DisplayPropertyView.DataSource = Property.getByPropertyType(typeName);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
    }
}
