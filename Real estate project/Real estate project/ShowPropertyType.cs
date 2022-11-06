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
    public partial class ShowPropertyType : Form
    {
        public ShowPropertyType()
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
            PropertyType a = new PropertyType();
            try
            {
                DisplayPropTypeView.DataSource = null;
                DisplayPropTypeView.DataSource = a.getAllPropertyType();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
    }
}
