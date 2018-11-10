using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApplication.StaticInformations;
using System.IO.Ports;
using DataApplication.Models;
using DataApplication.Devices;

namespace DataApplication.Views
{
    public partial class SerialDeviceConfig : UserControl, IDeviceConfigControl
    {
        private DeviceConfigModel dcm;
        public SerialDeviceConfig( DeviceConfigModel devConfigParam )
        {
            InitializeComponent();
            dcm = devConfigParam;
            dcm.Interface = DeviceInterface.SERIAL_INTERFACE;
            baudRateCb.DataSource = new BindingSource(SerialDeviceConfigurationTypes.baudRateOptions, null); 
            baudRateCb.DisplayMember = "Key";
            baudRateCb.ValueMember = "Value";

            parityBitsCb.DataSource = new BindingSource(SerialDeviceConfigurationTypes.parityOptions, null);
            parityBitsCb.DisplayMember = "Key";
            parityBitsCb.ValueMember = "Value";

            StopBitsCb.DataSource = new BindingSource(SerialDeviceConfigurationTypes.stopBitOptions, null);
            StopBitsCb.DisplayMember = "Key";
            StopBitsCb.ValueMember = "Value";

            List<string> ports = SerialPort.GetPortNames().ToList<string>();
            ports.Add("---");
            portNameCb.DataSource = ports.ToList<string>();
        }

        public DeviceConfigModel GetDeviceConfig()
        {
            return dcm;
        }

        public void SetDeviceConfig(DeviceConfigModel dcmParam)
        {
            dcm = dcmParam;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dcm.SerialPort = (string)portNameCb.SelectedItem;
                dcm.Parity = (Parity)parityBitsCb.SelectedValue;
                dcm.StopBit = (StopBits)StopBitsCb.SelectedValue;
                dcm.BaudRate = (int)baudRateCb.SelectedValue;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Lütfen programı tekrar çalıştırınız..");
            }
            catch(InvalidCastException)
            {
                MessageBox.Show("Lütfen geçerli değerler giriniz...");
            }
        }
    }
}
