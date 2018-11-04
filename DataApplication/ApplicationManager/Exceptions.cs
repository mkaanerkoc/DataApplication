using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationManager
{
    [Serializable]
    class DeviceModelNotFoundException : Exception
    {
        public DeviceModelNotFoundException()
        {
        }

        public DeviceModelNotFoundException(string message) : base(message)
        {
        }

        public DeviceModelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeviceModelNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
