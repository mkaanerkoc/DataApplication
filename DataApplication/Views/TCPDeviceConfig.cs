using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApplication.Models;
using System.Net;
using DataApplication.Devices;

namespace DataApplication.Views
{
    public partial class TCPDeviceConfig : UserControl
    {
        private DeviceConfigModel dcm;
        public TCPDeviceConfig( DeviceConfigModel devConfigParam )
        {
            InitializeComponent();
            dcm = devConfigParam;
            dcm.Interface = DeviceInterface.TCP_INTERFACE;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dcm.IPAdress = IPAddress.Parse(ipAddrTb.Text);
                dcm.Port = Convert.ToInt32(portNameTb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen tekrar deneyiniz...");
            }
        }
    }
}
