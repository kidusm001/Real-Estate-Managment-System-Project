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
    public partial class ShowAgents : Form
    {
        public ShowAgents()
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
            Agent a = new Agent();
            try
            {
                DisplayAgentsView.DataSource = null;
                DisplayAgentsView.DataSource = a.getAll();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void btnShowbyCommission_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            try
            {
                DisplayAgentsView.DataSource = null;
                DisplayAgentsView.DataSource = Agent.getAllByCommission();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
    }
}
