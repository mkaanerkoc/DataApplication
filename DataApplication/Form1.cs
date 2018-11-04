using DataApplication.Devices;
using DataApplication.Peripherals;
using DataApplication.Peripherals.MockDevices;
using DataApplication.View;
using DataApplication.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApplication
{
    public partial class Form1 : Form
    {
        PG250 pg250;
        public Form1()
        {
            InitializeComponent();
            IPeripheralInterface sp = new PG250Mock();//new SerialPeripheral(9600, Parity.Even, StopBits.None, "COM2");
            IViewUpdater vu = new FormUpdater(mainContainer);
            pg250 = new PG250("COM1", sp, vu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pg250.ReadDataChannels();
        }

        private void button2_Click( object sender, EventArgs e)
        {
            //IUDPDevice udpDevice = devFactory.createUDPDevice("PG300");
            //label1.Text = udpDevice.GetInformation();
        }
    }
}
