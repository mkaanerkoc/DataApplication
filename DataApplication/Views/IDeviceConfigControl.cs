using DataApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Views
{
    public interface IDeviceConfigControl
    {
        void SetDeviceConfig(DeviceConfigModel dcmParam);
        DeviceConfigModel GetDeviceConfig();
    }
}
