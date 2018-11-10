using DataApplication.Devices;
using DataApplication.Models;
using DataApplication.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Factories
{
    public class PeripheralFactory
    {
        public static IPeripheralInterface CreatePeripheral( DeviceConfigModel deviceConfigParam )
        {
            IPeripheralInterface retVal = null;

            if( deviceConfigParam.Interface == DeviceInterface.SERIAL_INTERFACE )
            {
                retVal = new SerialPeripheral( deviceConfigParam.BaudRate,
                                               deviceConfigParam.Parity,
                                               deviceConfigParam.StopBit,
                                               deviceConfigParam.DataBits,
                                               deviceConfigParam.SerialPort );
            }

            else if (deviceConfigParam.Interface == DeviceInterface.TCP_INTERFACE )
            {
                throw new NotImplementedException(" TCP Interface is not implemented yet ");
            }
            else if( deviceConfigParam.Interface == DeviceInterface.UDP_INTERFACE )
            {
                retVal = new UDPPeripheral( deviceConfigParam.Port,
                                            deviceConfigParam.IPAdress);
            }
            else
            {
                throw new NotImplementedException(" Unknown Interface param received ");
            }
            return retVal;
        }
    }
}
