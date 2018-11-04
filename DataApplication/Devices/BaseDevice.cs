using DataApplication.ApplicationManager;
using DataApplication.DataWriter;
using DataApplication.Peripherals;
using DataApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public abstract class BaseDevice
    {
        protected IPeripheralInterface _periphInterface;
        protected IDataWriter _writer;
        protected IViewUpdater _view;
        protected IErrorHandler _errorHandler;

        public abstract void ReadDeviceConfigFile();
        public abstract void ReadDataChannels();
        public abstract void ReadChannel(int channelId);
        public abstract void GetDiagnostics();
    }
}
