using DataApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApplication.Dialogs
{
    public partial class AddNewFacilityDialog : Form
    {
        public FacilityModel facilityModel { get; }
        public AddNewFacilityDialog()
        {
            InitializeComponent();
            facilityModel = new FacilityModel();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            facilityModel.Name = factoryNameTb.Text;
            facilityModel.City = cityComboBox.SelectedItem.ToString(); //example
            facilityModel.ID =  Convert.ToInt32( factoryIDTb.Text ); //example
             
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
