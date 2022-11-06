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
    public partial class SearchAdmin : Form
    {
        public SearchAdmin()
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

        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            string userName = txtAdminUsername.Text;
            Admin a = Admin.findAdmin(userName);
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
