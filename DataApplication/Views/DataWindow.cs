using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApplication.DataWriter;

namespace DataApplication.Views
{
    public partial class DataWindow : UserControl
    {
        public string Alias { get; }
        public string Unit { get; }
        private ContextMenu cm;
        public string Value
        {
            get
            {
                return Value;
            }
            set
            {
                valueTb.Text = value;
            }
        }

        public DataWindow()
        {
            InitializeComponent();
            InitialSettingsButtonMenu();
        }
        public DataWindow( string aliasParam, string unitParam )
        {
            Alias = aliasParam;
            Unit = unitParam;
            InitializeComponent();
            InitialSettingsButtonMenu();
            unitTb.Text = Unit;
            box.Text = Alias;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }
        private void InitialSettingsButtonMenu()
        {
            cm = new ContextMenu();
            cm.MenuItems.Add("Sakla").Click += DataWindow_Click1;
            cm.MenuItems.Add("Detaylar").Click += DataWindow_Click;
            settingsBtn.ContextMenu = cm;
        }

        private void DataWindow_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Sakla");
        }

        private void DataWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detaylar");
        }
    }
}
