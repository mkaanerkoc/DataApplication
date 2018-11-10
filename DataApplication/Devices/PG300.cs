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
        private const byte SOH = 0x01;
        private const byte STX = 0x02;
        private const byte ETX = 0x03;
        private const byte DEV_ID_1 = 49;
        private const byte DEV_ID_2 = 50;
        private static char PG300_SPLITTER_CHAR = ',';

        private static readonly byte[] R200_CMD = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 48, STX };
        private static readonly byte[] R201_CMD = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 49, STX };
        private static readonly byte[] R202_CMD = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 50, STX };

      

        public PG300()
        {

        }

        public PG300(   IPeripheralInterface interfaceParam,
                        IDataWriter dataWriter,
                        IViewUpdater viewParam )
        {
            _periphInterface = interfaceParam;
            _writer = dataWriter;
            _view = viewParam;
            _periphInterface.open();
        }

        public override int Begin()
        {
            _periphInterface.open();
            _writer.create(); // creates the file if it is needed to be created
            return 1;
        }

        public override int GetDiagnostics()
        {
            throw new NotImplementedException();
        }

        public String GetInformation()
        {
            return "<PG300> UDP Device ";
        }

        public override int ParseDeviceConfigFile()
        {
            throw new NotImplementedException();
        }

        public void PrintInformation()
        {
            throw new NotImplementedException();
        }

        public override int ReadChannel(int channelId)
        {
            throw new NotImplementedException();
        }

        public override int ReadDataChannels()
        {
            byte[] outBuffer = new byte[] { };
            if(_periphInterface.readUntil( R201_CMD, 0x03, ref outBuffer, 1000 ) > 10 )
            {
                string receivedStr = Encoding.ASCII.GetString(outBuffer);
                string[] receivedWords = receivedStr.Split( PG300_SPLITTER_CHAR );
                List<IWritable> list = new List<IWritable>();
                DateTime dt = DateTime.Now;
                list.Add(new Writable<string>(dt.ToShortDateString(), "Date", 0));
                list.Add(new Writable<string>(dt.ToShortTimeString(), "Time", 1));
                for (int i = 2; i < receivedWords.Length - 1; i++)
                {
                    string Value = "---";
                    string Name = "---";
                    int DataCode = 0;
                    try
                    {
                        DataCode = Convert.ToByte(receivedWords[i].Substring(0, 2));
                        Name = PG300Information.dataChannelsByIndexes[DataCode]; // burasi kritik
                        Value = receivedWords[i].Substring(9);
                    }
                    catch(Exception e )
                    {
                        _errorHandler.handleError(e);
                    }
                    list.Add(new Writable<string>(Value, Name, DataCode));
                }
                _view.update(list);
                //_writer.open("deneme.csv");
                if (_writer.open("deneme.xlsx") == 1)
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
            return 1;
        }


        public override int ReadDeviceInformation()
        {
            throw new NotImplementedException();
        }

        /* utils */
        private byte[] CalculateCheckSum(byte[] frame)
        {
            UInt16 fcs;
            byte[] returnArray = new byte[frame.Length + 3];
            fcs = 0x00;
            for (int i = 0; i < frame.Length; i++)
            {
                fcs ^= (byte)frame[i];
                returnArray[i] = frame[i];
            }
            //Console.WriteLine("Hex value is :{0}, First Digit Val :{1}, Second Digit val :{2}", fcs.ToString("X2"), , (byte)fcs.ToString("X2").ToCharArray()[1]);
            returnArray[frame.Length] = (byte)fcs.ToString("X2").ToCharArray()[0];
            returnArray[frame.Length + 1] = (byte)fcs.ToString("X2").ToCharArray()[1];
            returnArray[frame.Length + 2] = ETX;
            return returnArray;
        }

        private bool ValidateData(byte[] InputBuffer)
        {
            UInt16 fcs = 0x00;
            for (int i = 0; i < InputBuffer.Length - 3; i++)
            {
                fcs ^= (byte)InputBuffer[i];
            }
            byte FCS_1 = (byte)fcs.ToString("X2").ToCharArray()[0];
            byte FCS_2 = (byte)fcs.ToString("X2").ToCharArray()[1];
            //Console.WriteLine("FCS1 : {0},FCS1 : {1},xFCS1 : {2},xFCS2 : {3}", FCS_1, FCS_2, InputBuffer[InputBuffer.Length - 3], InputBuffer[InputBuffer.Length - 2]);
            if (FCS_1 == InputBuffer[InputBuffer.Length - 3] && FCS_2 == InputBuffer[InputBuffer.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
