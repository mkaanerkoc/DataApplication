using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using DataApplication.Models;
using DataApplication.Peripherals;
using DataApplication.DataWriter;

namespace DataApplication.Factories
{
    public class DeviceFactory
    {
        public static BaseDevice CreateDevice(string brandName, string modelName)
        {
            BaseDevice retVal;
            if( brandName.ToLower().Equals("horiba"))
            {
                if(modelName.ToLower().Equals("pg250"))
                {
                    retVal = new PG250();
                }
                else if ( modelName.ToLower().Equals("pg300"))
                {
                    retVal = new PG300();
                }
                else
                {
                    throw new NotImplementedException("Unkknown Model name "+ modelName + " for "+ brandName );
                }
            }
            else
            {
                throw new NotImplementedException("Unkknown Brand name " + brandName );
            }
            
            return retVal;
        }
    }

    [Serializable]
    internal class WrongDeviceConfigurationException : Exception
    {
        public WrongDeviceConfigurationException()
        {
        }

        public WrongDeviceConfigurationException(string message) : base(message)
        {
        }

        public WrongDeviceConfigurationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongDeviceConfigurationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
