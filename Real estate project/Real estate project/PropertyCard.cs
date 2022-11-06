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
    public partial class PropertyCard : UserControl
    {
        public PropertyCard()
        {
            InitializeComponent();
        }
        private string _Id, _PropertySize, _PropertyType, _OwnerId, _StreetName, _WoredaName, _ZoneName, _RegionName, _countryName;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; lblPropertyId.Text = _Id; }
        }
        public string PropertySize
        {
            get { return _PropertySize; }
            set { _PropertySize = value; lblPropertySize.Text = _PropertySize; }
        }
        public string PropertyType
        {
            get { return _PropertyType; }
            set { _PropertyType = value; lblPropertyType.Text = _PropertyType; }
        }
        public string OwnerId
        {
            get { return _OwnerId; }
            set { _OwnerId = value; lblOwnerId.Text = _OwnerId; }
        }
        public string StreetName
        {
            get { return _StreetName; }
            set { _StreetName = value; lblStreetName.Text = _StreetName; }
        }
        public string WoredaName
        {
            get { return _WoredaName; }
            set { _WoredaName = value; lblWoredaName.Text = _WoredaName; }
        }
        public string ZoneName
        {
            get { return _ZoneName; }
            set { _ZoneName = value; lblZoneName.Text = _ZoneName; }
        }
        public string RegionName
        {
            get { return _RegionName; }
            set { _RegionName = value; lblRegionName.Text = _RegionName; }
        }
        public string countryName
        {
            get { return _countryName; }
            set { _countryName = value; lblCountryName.Text = _countryName; }
        }
    }
}
