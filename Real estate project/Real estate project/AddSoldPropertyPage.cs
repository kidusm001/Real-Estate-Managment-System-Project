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
    public partial class AddSoldPropertyPage : Form
    {
        public AddSoldPropertyPage()
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
                SellerId = int.Parse(txtSellerId.Text),
                BuyerId = int.Parse(txtBuyerId.Text),
                DateSold=DateTime.Parse(txtDateSold.Text),
                AgentId = int.Parse(txtAgentID.Text),
                Price=double.Parse(txtPrice.Text)
            };
            try
            {
                int rowsAffected = a.AddSoldProperty();
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
