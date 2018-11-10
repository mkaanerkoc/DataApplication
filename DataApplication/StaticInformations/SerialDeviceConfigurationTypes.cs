using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.StaticInformations
{
    public class SerialDeviceConfigurationTypes
    {
        public static ReadOnlyDictionary<string, int> baudRateOptions = new ReadOnlyDictionary<string, int>(
            new Dictionary<string, int>()
            {
                {"4800",4800 },
                {"9600", 9600 },
                {"19200",19200 },
                {"38400",38400 }
            });
        public static ReadOnlyDictionary<string, StopBits> stopBitOptions = new ReadOnlyDictionary<string, StopBits>(
            new Dictionary<string, StopBits>()
            {
                {"None",StopBits.None },
                {"1", StopBits.One },
                {"1.5",StopBits.OnePointFive },
                {"2",StopBits.Two }
            });
        public static ReadOnlyDictionary<string, Parity> parityOptions = new ReadOnlyDictionary<string, Parity>(
            new Dictionary<string, Parity>()
            {
                {"Even",Parity.Even },
                {"Mark", Parity.Mark },
                {"None",Parity.None },
                {"Odd",Parity.Odd },
                {"Space",Parity.Space }
            });
    }
}
