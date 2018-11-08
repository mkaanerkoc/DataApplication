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

        private static readonly byte[] C01_CMD = new byte[] { 67, 48, 49, 53, 67, 13, 10 };
        private static readonly byte[] C23_CMD = new byte[] { 67, 50, 51, 53, 56, 13, 10 };

        private static char PG250_SPLITTER_CHAR = ',';

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
            //_writer = new CSVWriter(";");
            _writer = new ExcelWriter();
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
            byte[] outBuffer = new byte[] { };

            if( _periphInterface.readUntil( C01_CMD, 10, ref outBuffer, 1000 ) > 5 )
            {
                List<IWritable> list = ParseResponse(outBuffer);
                _view.update( list );
                //_writer.open("deneme.csv");
                if( _writer.open("deneme.xlsx") == 1 )
                {
                    _writer.write(list);
                    _writer.close();
                    return 1;
                }
                else
                {
                    return -1;
                }
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
            if (_periphInterface.read(C23_CMD, responseLength, ref outBuffer, 1000) > 0)
            {

            }
            return 1;
        }

        private List<IWritable> ParseResponse(byte[] response)
        {
            //burayi begenmedim hic
            List<IWritable> list = new List<IWritable>();
            DateTime dt = DateTime.Now;
            list.Add(new Writable<string>(dt.ToLongTimeString(), "DateTime", 9));

            string receivedStr = Encoding.ASCII.GetString(response);
            string[] receivedWords = receivedStr.Split(PG250_SPLITTER_CHAR);
            list.Add(new Writable<string>(dt.ToShortDateString(), "Date", 0));
            list.Add(new Writable<string>(dt.ToShortTimeString(), "Time", 0));
            for (int i = 0; i < 9; i++)
            {
                string str = receivedWords[i + 2];
                string Name = PG250Information.dataChannelsByIndexes[i];
                string Value = "---";
                if (str[5] != 'C')
                {
                    Value = str.Substring(6, 5);
                }
                list.Add(new Writable<string>(Value, Name, 0));
            }
            return list;
        }

        public override int ReadDeviceInformation()
        {
            throw new NotImplementedException();
        }
    }
}
