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

        protected DeviceModel _model;

        public int SetDataWriter( IDataWriter param )
        {
            _writer = param;
            return 1;
        }
        public int SetViewUpdater( IViewUpdater param )
        {
            _view = param;
            return 1;
        }

        public int SetPeripheralInterface (IPeripheralInterface param )
        {
            _periphInterface = param;
            return 1;
        }
        
        public int SetErrorHandler( IErrorHandler param )
        {
            _errorHandler = param;
            return 1;
        }

        public int SetDeviceModel( DeviceModel param )
        {
            _model = param;
            return 1;
        }

        public DeviceModel GetModel()
        {
            return _model;
        }
        public abstract int Begin();
        public abstract int ParseDeviceConfigFile();
        public abstract int ReadDeviceInformation();
        public abstract int ReadDataChannels();
        public abstract int ReadChannel(int channelId);
        public abstract int GetDiagnostics();
    }
}
