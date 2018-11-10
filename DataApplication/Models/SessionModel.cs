using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Models
{
  
    public class SessionModel
    {
        public BaseDevice Device { get; set; }
        public string Filename { get; set; }
        public DataStorageType DBType { get; set; }
        public double Period { get; set; }
        public List<ChannelModel> Channels { get; set; }

    }
}
