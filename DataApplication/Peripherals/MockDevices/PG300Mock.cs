using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Peripherals.MockDevices
{
    public class PG300Mock : MockDeviceBase, IPeripheralInterface
    {
        public int close()
        {
            throw new NotImplementedException();
        }

        public int open()
        {
            throw new NotImplementedException();
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
            if(cmd.Length != 3 )
            {
                return 0;
            }
            if( cmd[0] == 'R' && cmd[1] == '2' && cmd[2] == '0' && cmd[2] == '1')
            {
                Random rnd = new Random();
                // copy data to outbuffer
                outbuffer[0] = (byte)'C';
                outbuffer[1] = (byte)'0';
                outbuffer[2] = (byte)'1';
                outbuffer[3] = (byte)'1';
                for( int k = 0; k < 30; k++ )
                {
                    outbuffer[k + 3] = (byte)rnd.Next(40, 90);
                }
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
