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
    public partial class AddPropertyToSellList : Form
    {
        public AddPropertyToSellList()
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
            Property a = new Property
            {
                PropertyId = int.Parse(txtPropertyId.Text),
                IsAvailable = rbtnAvailable.Checked ? true : false,
                Price=double.Parse(txtPrice.Text),
                OwnerId=int.Parse(txtOwnerId.Text),
                AgentId= int.Parse(txtAgentId.Text)
            };
            try
            {
                int rowsAffected = a.AddtoListforSell();
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
