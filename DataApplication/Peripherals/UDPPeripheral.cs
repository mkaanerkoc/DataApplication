using DataApplication.ApplicationManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DataApplication.Peripherals
{
    public class UDPPeripheral : IPeripheralInterface
    {
        private UdpClient client;
        private Thread thdUDPServer;
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
                thdUDPServer = new Thread(new ThreadStart(udpListenerThread));
                thdUDPServer.Start();
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
                thdUDPServer.Abort();
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

        public int readUntil(byte[] cmd, byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int readAsync(byte[] cmd, ref byte[] outbuffer)
        {
            throw new NotImplementedException();
        }

        public int write(byte[] param)
        {
            UdpClient udpClient = new UdpClient(_portNum);
            udpClient.Connect(_ipEndpoint);
            udpClient.Send(param, param.Length);
            udpClient.Close();
            return 1;
        }

        public int writeAsync(byte[] param)
        {
            throw new NotImplementedException();
        }


        private void udpListenerThread()
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient udpClient = new UdpClient(_portNum);
            while (true)
            {
                //udpClient.Client.Bind(RemoteIpEndPoint);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnDataStr = Encoding.ASCII.GetString(receiveBytes);
                Console.WriteLine("Received Data " + returnDataStr);            
            }
        }

    }

}
