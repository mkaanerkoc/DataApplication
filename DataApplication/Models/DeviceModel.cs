using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

    public class DeviceModel : ISerializable
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public DeviceInterface Interface { get; set; }
        public DeviceCmdFrame Frame { get; set; }
        public List<ChannelModel> Channels { get; set; }
        
        public DeviceModel()
        {

        }

        public DeviceModel( string nameParam, 
                            DeviceInterface interfaceParam, 
                            DeviceCmdFrame frameParam )
        {
            Channels = new List<ChannelModel>();
            Name = nameParam;
            Interface = interfaceParam;
            Frame = frameParam;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("Interface", this.Interface);
            info.AddValue("FrameType", this.Frame);
            info.AddValue("Channels", this.Channels);
        }
    }

    public class ChannelModel
    {
        [XmlAttribute("Name")]
        public string name { get; set; }
        [XmlElement("Unit")]
        public string unit { get; set; }
        [XmlElement("Min")]
        public double minimum { get; set; }
        [XmlElement("Max")]
        public double maximum { get; set; }
        [XmlElement("Type")]
        public ChannelType type { get; set; }

        public ChannelModel()
        {

        }
        public ChannelModel( string nameParam, string unitParam, double minParam, double maxParam, ChannelType typeParam )
        {
            name = nameParam;
            unit = unitParam;
            minimum = minParam;
            maximum = maxParam;
            type = typeParam;
        }
    }
}
