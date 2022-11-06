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
    public partial class DeleteSoldProperty : Form
    {
        public DeleteSoldProperty()
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

        private void btnDeleteSold_Click(object sender, EventArgs e)
        {
            int tId = int.Parse(txtTransactionID.Text);
            Property a = new Property();
            try
            {
                int rowsAffected = a.DeleteSoldProperty(tId);
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
