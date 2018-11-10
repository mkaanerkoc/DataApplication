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
        public static BaseDevice CreateDevice( DeviceModel modelParam)
        {
            BaseDevice retVal;
            if(modelParam.Brand.ToLower().Equals("horiba"))
            {
                if(modelParam.Model.ToLower().Equals("pg250"))
                {
                    retVal = new PG250();
                    retVal.SetDeviceModel( modelParam );
                }
                else if ( modelParam.Model.ToLower().Equals("pg300"))
                {
                    retVal = new PG300();
                    retVal.SetDeviceModel(modelParam);
                }
                else
                {
                    throw new NotImplementedException("Unkknown Model name "+ modelParam.Model + " for "+ modelParam.Brand);
                }
            }
            else
            {
                throw new NotImplementedException("Unkknown Brand name " + modelParam.Brand);
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
