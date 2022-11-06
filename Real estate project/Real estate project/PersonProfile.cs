using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_estate_project
{
    public partial class PersonProfile : UserControl
    {
        public PersonProfile()
        {
            InitializeComponent();
        }
        private string _Id, _FullName, _Email, _HPhone, _MPhone;
        public string Id
            {
            get { return _Id; }
            set { _Id = value; lblId.Text = _Id; }
        }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; lblFullName.Text = _FullName; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; lblEmail.Text = _Email; }
        }
        public string HPhone
        {
            get { return _HPhone; }
            set { _HPhone = value; lblHomePhone.Text = _HPhone; }
        }
        public string MPhone
        {
            get { return _MPhone; }
            set { _MPhone = value; lblMobilePhone.Text = _MPhone; }
        }
    }
}
