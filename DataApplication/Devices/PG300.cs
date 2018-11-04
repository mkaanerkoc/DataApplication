using DataApplication.DataWriter;
using DataApplication.Peripherals;
using DataApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public class PG300 : BaseDevice
    {
        private static readonly byte[] cmd1 = new byte[] { (byte)'R', (byte)'2', (byte)'0', (byte)'0' };
        private static readonly byte[] cmd2 = new byte[] { (byte)'R', (byte)'2', (byte)'0', (byte)'1' };
        private static readonly byte[] cmd3 = new byte[] { (byte)'R', (byte)'2', (byte)'0', (byte)'2' };


        public PG300(string portName)
        {
            _periphInterface = new UDPPeripheral(50, new IPEndPoint(4000,50));
            _periphInterface.open();
        }

        public PG300(   string portName, 
                        IPeripheralInterface interfaceParam,
                        IViewUpdater viewParam )
        {
            _periphInterface = interfaceParam;
            _writer = new CSVWriter(";");
            _view = viewParam;
            _periphInterface.open();
        }

        public override void GetDiagnostics()
        {
            throw new NotImplementedException();
        }

        public String GetInformation()
        {
            return "<PG300> UDP Device ";
        }

        public void PrintInformation()
        {
            throw new NotImplementedException();
        }

        public override void ReadChannel(int channelId)
        {
            throw new NotImplementedException();
        }

        public override void ReadDataChannels()
        {
            byte[] outBuffer = new byte[] { };
            int responseLength = 33;
            if (_periphInterface.read(cmd1, responseLength, ref outBuffer, 1000 ) == 7)
            {

            }
        }

        public override void ReadDeviceConfigFile()
        {
            Console.WriteLine("<PG300> ReadDeviceConfigFile");
        }
    }
}
