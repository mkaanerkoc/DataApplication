using DataApplication.ApplicationManager;
using DataApplication.DataWriter;
using DataApplication.Peripherals;
using DataApplication.View;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Devices
{
    public class PG250 : BaseDevice
    {
        private static readonly byte[] cmd1 = new byte[] { (byte)'C', (byte)'0', (byte)'1' };
        private static readonly byte[] cmd2 = new byte[] { (byte)'C', (byte)'2', (byte)'3' };
        private static readonly byte[] cmd3 = new byte[] { (byte)'C', (byte)'0', (byte)'3' };

        public PG250( string portName )
        {
            _periphInterface = new SerialPeripheral( 9600, Parity.Even, StopBits.None, portName);
            _writer = new CSVWriter("deneme.csv");
            _errorHandler = new FileErrorHandler("pg250_logs.txt");
            _periphInterface.open();
        }
        
        public PG250(   string portName, 
                        IPeripheralInterface interfaceParam, 
                        IViewUpdater viewParam )
        {
            _periphInterface = interfaceParam;
            _writer = new CSVWriter(";");
            _periphInterface.open();
            _view = viewParam;
        }
        
        public override int ParseDeviceConfigFile()
        {
            Console.WriteLine("<PG250> ReadDeviceConfigFile \n");
            return 0;
        }

        public String GetInformation()
        {
            return "<PG250> printInformation...";
        }

        public override int ReadDataChannels()
        {
            int responseLength = 12;
            byte[] outBuffer = new byte[] { };
            if(_periphInterface.read(cmd1, responseLength, ref outBuffer, 1000 ) == responseLength)
            {
                List<IWritable> list = ParseResponse(outBuffer);
                _view.update(list);
                _writer.open("deneme.csv");
                _writer.write(list);
                _writer.close();
                return 1;
            }
            else
            {
                _errorHandler.handleErrorMessage("Yanit gelmedi...");
                return -1;
            }
            
        }

        public override int ReadChannel(int channelId)
        {
            return -1;
        }

        public override int GetDiagnostics()
        {
            int responseLength = 13;
            byte[] outBuffer = new byte[] { };
            _periphInterface.read(cmd2, responseLength, ref outBuffer, 1000 );
        }

        private List<IWritable> ParseResponse(byte[] response)
        {
            //burayi begenmedim hic
            List<IWritable> list = new List<IWritable>();
            DateTime dt = DateTime.Now;
            list.Add(new Writable<string>(dt.ToShortTimeString(), "DateTime", 9));
            list.Add(new Writable<double>(Convert.ToDouble(response[3]), "NO",0));
            list.Add(new Writable<double>(Convert.ToDouble(response[4]), "NOx",1));
            list.Add(new Writable<double>(Convert.ToDouble(response[5]), "Corr. NO",2));
            list.Add(new Writable<double>(Convert.ToDouble(response[6]), "Corr. NOx",3));
            list.Add(new Writable<double>(Convert.ToDouble(response[7]), "CO",4));
            list.Add(new Writable<double>(Convert.ToDouble(response[8]), "CO2",5));
            list.Add(new Writable<double>(Convert.ToDouble(response[9]), "O2",6));
            list.Add(new Writable<double>(Convert.ToDouble(response[10]), "SO2",7));
            list.Add(new Writable<double>(Convert.ToDouble(response[11]), "Corr. SO2",8));
            return list;
        }

        
    }
}
