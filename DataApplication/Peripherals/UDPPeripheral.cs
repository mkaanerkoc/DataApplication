using DataApplication.ApplicationManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Peripherals
{
    public class UDPPeripheral : IPeripheralInterface
    {
        private UdpClient client;
        private int _portNum;
        private IErrorHandler _errorHandler;
        private IPEndPoint _ipEndpoint;

        public UDPPeripheral(int portNum, IPEndPoint ipAddr )
        {
            _portNum = portNum;
            client = new UdpClient();
            _errorHandler = new ConsoleErrorHandler();
        }

        public UDPPeripheral( int portNum, IPEndPoint ipAddr, IErrorHandler errHandler )
        {
            _portNum = portNum;
            _ipEndpoint = ipAddr;
            _errorHandler = errHandler;
            client = new UdpClient();
            _errorHandler = errHandler;
        }


        public int open()
        {
            try
            {
                client.Connect(_ipEndpoint);
                return 1;
            }
            catch(Exception e )
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int close()
        {
            try
            {
                client.Close();
                return 1;
            }
            catch(Exception e )
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int read(int size, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read( byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read(byte[] cmd, int size, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read(byte[] cmd, byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int readAsync(byte[] cmd, ref byte[] outbuffer)
        {
            throw new NotImplementedException();
        }

        public int write(byte[] param)
        {
            throw new NotImplementedException();
        }

        public int writeAsync(byte[] param)
        {
            throw new NotImplementedException();
        }
    }

}
