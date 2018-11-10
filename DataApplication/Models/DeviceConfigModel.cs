using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Models
{
    public class DeviceConfigModel
    {
        public string SerialPort { get; set; }
        public int Port { get; set; }
        public IPAddress IPAdress { get; set; }
        public Parity Parity { get; set; }
        public StopBits StopBit { get; set; }
        public int BaudRate { get; set; }
        public string Filename { get; set; }
        public DeviceInterface Interface { get; set; }
        public DeviceConfigModel()
        {
            SerialPort = "";
            Filename = "";
        }

    }
}
