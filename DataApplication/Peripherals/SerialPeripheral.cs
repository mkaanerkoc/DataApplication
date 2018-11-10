using DataApplication.ApplicationManager;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApplication.Peripherals
{
    public class SerialPeripheral : IPeripheralInterface
    {
        private SerialPort _port;
        private IErrorHandler _errorHandler;

        public SerialPeripheral( int baudRate, Parity parityBits, StopBits stopBits, int dataBits, string portName )
        {
            _port = new SerialPort();
            _errorHandler = new ConsoleErrorHandler();
            _port.BaudRate = baudRate;
            _port.Parity = parityBits;
            _port.StopBits = stopBits;
            _port.DataBits = dataBits;
            _port.PortName = portName;
        }

        public SerialPeripheral(int baudRate, Parity parityBits, StopBits stopBits, int dataBits, string portName, IErrorHandler errHandler )
        {
            _port = new SerialPort();
            _errorHandler = errHandler;
            _port.BaudRate = baudRate;
            _port.Parity = parityBits;
            _port.StopBits = stopBits;
            _port.DataBits = dataBits;
            _port.PortName = portName;
        }

        public int open()
        {
            try
            {
                _port.Open();
                return 1;
            }   
            catch( Exception e)
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int close()
        {
            try
            {
                _port.Close();
                return 1;
            }
            catch (Exception e)
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int read(byte[] cmd, int size, ref byte[] outbuffer, int timeout = 500 )
        {
            try
            {
                _port.Write(cmd, 0, cmd.Length);
                _port.ReadTimeout = timeout;
                return _port.Read(outbuffer, 0, size);
            }
            catch (Exception e)
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int read(int size, ref byte[] outbuffer,int timeout = 500 )
        {
            try
            {
                _port.ReadTimeout = timeout;
                return _port.Read(outbuffer, 0, size);

            }
            catch (Exception e)
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int read(byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            try
            {
                _port.ReadTimeout = timeout;
                string buf = _port.ReadTo(endbyte.ToString());
                outbuffer = Encoding.ASCII.GetBytes(buf);
                return outbuffer.Length;
            }
            catch( Exception e )
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int readUntil(byte[] cmd, byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            try
            {
                _port.Write(cmd, 0, cmd.Length);
                _port.ReadTimeout = timeout;
                string buf = _port.ReadTo(endbyte.ToString());
                outbuffer = Encoding.ASCII.GetBytes(buf);
                return outbuffer.Length;
            }
            catch (Exception e)
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }
        public int readAsync( byte[] cmd, ref byte[] outbuffer)
        {
            throw new NotImplementedException();
        }

        public int write(byte[] param)
        {
            try
            {
                _port.Write(param, 0, param.Length);
                return param.Length;
            }
            catch(Exception e )
            {
                _errorHandler.handleError(e);
                return -1;
            }
        }

        public int writeAsync(byte[] param)
        {
            throw new NotImplementedException();
        }
        
    }
}
