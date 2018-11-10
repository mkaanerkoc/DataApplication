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
    public partial class AddNewMeasurementPointDialog : Form
    {
        public MeasurementPointModel measurementPoint { get;  }

        public AddNewMeasurementPointDialog()
        {
            InitializeComponent();
            measurementPoint = new MeasurementPointModel();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            measurementPoint.Name = bacaName.Text;
            measurementPoint.ID = Convert.ToInt32(bacaID.Text); //example
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
