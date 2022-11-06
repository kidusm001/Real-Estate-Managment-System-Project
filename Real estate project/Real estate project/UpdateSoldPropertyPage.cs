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
    public partial class UpdateSoldPropertyPage : Form
    {
        public UpdateSoldPropertyPage()
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
                TransactionId = int.Parse(txtTransactionId.Text),
                PropertyId = int.Parse(txtPropertyId.Text),
                SellerId = int.Parse(txtSellerId.Text),
                BuyerId = int.Parse(txtBuyerId.Text),
                DateSold = DateTime.Parse(txtDateSold.Text),
                AgentId = int.Parse(txtAgentID.Text),
                Price = double.Parse(txtPrice.Text)
            };
            try
            {
                int rowsAffected = a.updateSoldProperty();
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
