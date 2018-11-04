using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public abstract class BaseDevice
    {
        public abstract void ReadDeviceConfigFile();
        public abstract void ReadDataChannels();
        public abstract void ReadChannel(int channelId);
        public abstract void GetDiagnostics();
    }
}
