using DataApplication.ApplicationManager;
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
    public partial class ProgramParameters : Form
    {
        public ProgramParameters()
        {
            InitializeComponent();

            userList.DataSource = ConfigurationManager.config.operators;
            userList.DisplayMember = "DisplayName";

            factoryList.DataSource = ConfigurationManager.config.facilities;
            factoryList.DisplayMember = "ListDisplay";
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {

        }

        private void addUserBt_Click(object sender, EventArgs e)
        {
            using (var form = new AddNewUserDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    OperatorModel newOperator = form.operatorModel;            //values preserved after close
                    ConfigurationManager.config.operators.Add(newOperator);
                }
            }
        }

        private void deleteUserBt_Click(object sender, EventArgs e)
        {

        }

        private void addFactoryBt_Click(object sender, EventArgs e)
        {
            using (var form = new AddNewFacilityDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FacilityModel newFactory = form.facilityModel;            //values preserved after close
                    ConfigurationManager.config.facilities.Add(newFactory);
                }
            }
        }

        private void mailListAddBt_Click(object sender, EventArgs e)
        {

        }

        private void addBacaBt_Click(object sender, EventArgs e)
        {
            int i = factoryList.SelectedIndex;
            if (i == -1)
            {
                MessageBox.Show("Tesis listesinden tesis seçiniz");
                return;
            }
            using (var form = new AddNewMeasurementPointDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MeasurementPointModel newPoint = form.measurementPoint;
                    ConfigurationManager.config.facilities[i].Points.Add(newPoint);
                }
            }
        }
    }
}
