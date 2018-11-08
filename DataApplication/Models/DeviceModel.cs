using System.Collections.Generic;
using System.Runtime.Serialization;
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

    public enum DeviceModelEnum
    {
        HORIBA_PG250,
        HORIBA_PG300
    }

    public class DeviceModel
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public DeviceInterface Interface { get; set; }
        public DeviceCmdFrame Frame { get; set; }
        public List<ChannelModel> Channels { get; set; }
        
        public string DisplayName
        {
            get
            {
                return Brand + "-" + Model;
            }
        }

        public DeviceModel()
        {

        }

        public DeviceModel( string brandParam,
                            string modelParam, 
                            DeviceInterface interfaceParam, 
                            DeviceCmdFrame frameParam )
        {
            Channels = new List<ChannelModel>();
            Brand = brandParam;
            Model = modelParam;
            Interface = interfaceParam;
            Frame = frameParam;
        }

        public DeviceModel( string brandParam,
                            string modelParam,
                            DeviceInterface interfaceParam,
                            DeviceCmdFrame frameParam,
                            List<ChannelModel> channelListParam )
        {
            Channels = channelListParam;
            Brand = brandParam;
            Model = modelParam;
            Interface = interfaceParam;
            Frame = frameParam;
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
