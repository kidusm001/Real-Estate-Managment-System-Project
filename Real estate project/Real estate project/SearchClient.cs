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
    public partial class SearchClient : Form
    {
        public SearchClient()
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

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            string userName = txtClientUsername.Text;
            Client a = Client.findClient(userName);
            PersonProfile p = new PersonProfile();
            p.Id = a.Id.ToString();
            p.FullName = a.FirstName + " " + a.LastName;
            p.Email = a.Email;
            p.HPhone = a.HomephoneNumber;
            p.MPhone = a.MobilephoneNumber;
            p.Dock = DockStyle.Bottom;
            panel1.Controls.Add(p);
        }
    }
}
