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
    public partial class ShowPropertytobeSoldbyOwner : Form
    {
        public ShowPropertytobeSoldbyOwner()
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

        private void btnShowbyOwnerId_Click(object sender, EventArgs e)
        {
            int Aid = int.Parse(txtOwnerID.Text);
            Property a = new Property();
            try
            {
                DisplayPropertytobesoldView.DataSource = null;
                DisplayPropertytobesoldView.DataSource = Property.getPropertytoBeSoldByOwner(Aid);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
    }
}
