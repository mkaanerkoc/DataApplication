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
    public partial class AddNewUserDialog : Form
    {
        public OperatorModel operatorModel { get; }

        public AddNewUserDialog()
        {
            InitializeComponent();
            operatorModel = new OperatorModel();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            try
            {
                operatorModel.Name = opNameTb.Text;
                operatorModel.Surname = opSurnameTb.Text; //example
                operatorModel.ID = Convert.ToInt32(opIDTb.Text); //example
                DialogResult = DialogResult.OK;
            }
            catch ( Exception )
            {
                MessageBox.Show("Hatalı değer girdiniz..");
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
