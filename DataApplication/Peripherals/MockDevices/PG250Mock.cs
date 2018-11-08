using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Peripherals.MockDevices
{
    public class PG250Mock : MockDeviceBase, IPeripheralInterface
    {
        private string C01Result = "R01, 6,A2500C?????,A2500A   -1,A2500C?????,A2500A   -0,A 500A  0.3,B  20B 0.01,B  25B20.49,A 200A  0.2,A 200A  0.0EB\r\n";
        private string C23Result = "R23,0,0.4, 52.31B\r\n";

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
            throw new NotImplementedException();
        }

        public int readUntil(byte[] cmd, byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            byte[] tempBuffer = new byte[C01Result.Length];
            if (cmd.Length != 7)
            {
                return 0;
            }
            if (cmd[0] == 'C' && cmd[1] == '0' && cmd[2] == '1')
            {
                for (int k = 0; k < C01Result.Length; k++)
                {
                    tempBuffer[k] = (byte)C01Result[k];
                }
                outbuffer = tempBuffer;
                return C01Result.Length;
            }
            else if (cmd[0] == 'C' && cmd[1] == '2' && cmd[2] == '3')
            {
                for (int k = 0; k < C23Result.Length; k++)
                {
                    tempBuffer[k] = (byte)C23Result[k];
                }
                outbuffer = tempBuffer;
                return C23Result.Length;
            }
            else
            {
                return 0;
            }
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
