using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public class DeviceInformations
    {
        public static readonly List<DeviceModel> devices = new List<DeviceModel>()
        {
            new DeviceModel(    "Horiba",
                                "PG250",
                                DeviceInterface.SERIAL_INTERFACE, 
                                DeviceCmdFrame.CSV_FRAME, 
                                new List<ChannelModel> {
                                    new ChannelModel("NO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("NOx", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Correlated NO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Correlated NOx", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("CO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("CO2", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("O2", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("SO2", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("Correlated SO2", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("Flow Rate", "%", 0, 100, ChannelType.DIAGNOSTIC_CHANNEL),
                                    new ChannelModel("Temperature", "C", 0, 100, ChannelType.DIAGNOSTIC_CHANNEL)
                                }
                            ),
             new DeviceModel(   "Horiba",
                                "PG300",
                                DeviceInterface.UDP_INTERFACE, 
                                DeviceCmdFrame.CSV_FRAME,
                                new List<ChannelModel> {
                                    new ChannelModel("NO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted NO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("NO avg", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted NO avg", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("NOx", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted NOx", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("NOx avg", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted NOx", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("SO2", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted SO2", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("SO2 avg", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted CO avg", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                   
                                    new ChannelModel("CH4", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("CH4 avg", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("CO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted CO", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("CO avg", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("Converted CO avg", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("CO2", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("CO2 avg", "%", 0, 100, ChannelType.DATA_CHANNEL),

                                    new ChannelModel("O2", "%", 0, 100, ChannelType.DATA_CHANNEL),
                                    new ChannelModel("O2 avg", "%", 0, 100, ChannelType.DATA_CHANNEL)
                                }
                            ),
        };
    }
}
