using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Peripherals.MockDevices
{
    public class PG250Mock : MockDeviceBase, IPeripheralInterface
    {
        public int close()
        {
            return 1;
        }

        public int open()
        {
            return 1;
        }

        public int read(int size, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read(byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read(byte[] cmd, int size, ref byte[] outbuffer, int timeout = 500)
        {
            byte[] tempBuffer = new byte[size];
            if (cmd.Length != 3)
            {
                return 0;
            }
            if (cmd[0] == 'C' && cmd[1] == '0' && cmd[2] == '1')
            {
                Random rnd = new Random();
                // copy data to outbuffer
                tempBuffer[0] = (byte)'R';
                tempBuffer[1] = (byte)'0';
                tempBuffer[2] = (byte)'1';
                tempBuffer[3] = (byte)(rnd.Next(20, 30));
                tempBuffer[4] = (byte)(rnd.Next(40, 50));
                tempBuffer[5] = (byte)(rnd.Next(60, 80));
                tempBuffer[6] = (byte)(rnd.Next(120, 160));
                tempBuffer[7] = (byte)(rnd.Next(20, 30));
                tempBuffer[8] = (byte)(rnd.Next(40, 50));
                tempBuffer[9] = (byte)(rnd.Next(60, 80));
                tempBuffer[10] = (byte)(rnd.Next(120, 160));
                tempBuffer[11] = (byte)(rnd.Next(120, 160));
                outbuffer = tempBuffer;
                return size;
            }
            else
            {
                return 0;
            }
            return 1;
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
