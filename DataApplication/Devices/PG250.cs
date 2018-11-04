﻿using DataApplication.ApplicationManager;
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
        
        public override void ReadDeviceConfigFile()
        {
            Console.WriteLine("<PG250> ReadDeviceConfigFile \n");
        }

        public String GetInformation()
        {
            return "<PG250> printInformation...";
        }

        public override void ReadDataChannels()
        {
            int responseLength = 12;
            byte[] outBuffer = new byte[] { };
            if(_periphInterface.read(cmd1, responseLength, ref outBuffer, 1000 ) == responseLength)
            {
                List<WritableBase> list = ParseResponse(outBuffer);
                _view.update(list);
                _writer.open("deneme.csv");
                _writer.write(list);
                _writer.close();
            }
            else
            {
                _errorHandler.handleErrorMessage("Yanit gelmedi...");
            }
            
        }

        public override void ReadChannel(int channelId)
        {
            return;
        }

        public override void GetDiagnostics()
        {
            int responseLength = 13;
            byte[] outBuffer = new byte[] { };
            _periphInterface.read(cmd2, responseLength, ref outBuffer, 1000 );
        }

        private List<WritableBase> ParseResponse(byte[] response)
        {
            //burayi begenmedim hic
            List<WritableBase> list = new List<WritableBase>();
            list.Add(new ChannelData(Convert.ToDouble(response[3]), "NO"));
            list.Add(new ChannelData(Convert.ToDouble(response[4]), "NOx"));
            list.Add(new ChannelData(Convert.ToDouble(response[5]), "Corr. NO"));
            list.Add(new ChannelData(Convert.ToDouble(response[6]), "Corr. NOx"));
            list.Add(new ChannelData(Convert.ToDouble(response[7]), "CO"));
            list.Add(new ChannelData(Convert.ToDouble(response[8]), "CO2"));
            list.Add(new ChannelData(Convert.ToDouble(response[9]), "O2"));
            list.Add(new ChannelData(Convert.ToDouble(response[10]), "SO2"));
            list.Add(new ChannelData(Convert.ToDouble(response[11]), "Corr. SO2"));
            return list;
        }

        
    }
}