using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Peripherals
{
    public interface IPeripheralInterface
    {
        int open();
        int close();
        int read(byte endbyte, ref byte[] outbuffer, int timeout = 500);
        int read( byte[] cmd, byte endbyte, ref byte[] outbuffer, int timeout = 500);
        int read( int size, ref byte[] outbuffer, int timeout = 500 );
        int read( byte[] cmd, int size, ref byte[] outbuffer, int timeout = 500 );
        int write( byte[] param );
        int readAsync( byte[] cmd, ref byte[] outbuffer);
        int writeAsync( byte[] param);
    }
}
