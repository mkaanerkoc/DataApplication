using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public enum ChannelType
    {
        DIAGNOSTIC_CHANNEL,
        DATA_CHANNEL
    }

    public enum DeviceInterface
    {
        SERIAL_INTERFACE,
        UDP_INTERFACE,
        TCP_INTERFACE
    }

    public enum DeviceCmdFrame
    {
        CSV_FRAME,
        MODBUS_SERIAL_FRAME,
        MODBUS_TCP_FRAME
    }

    public class DeviceModel
    {
        public string Name { get; set; }
        public DeviceInterface Interface { get; set; }
        public DeviceCmdFrame Frame { get; set; }
        public List<ChannelModel> Channels { get; set; }
    }

    public class ChannelModel
    {
        public string name { get; set; }
        public string unit { get; set; }
        public double minimum { get; set; }
        public double maximum { get; set; }
        public ChannelType type { get; set; }
    }
}
