using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public class ChannelData : WritableBase
    {
        public double value { get; set; }

        public ChannelData(double valueParam, string aliasParam )
        {
            alias = aliasParam;
            value = valueParam;
        }
        public override string ToString()
        {
            return Convert.ToString(value);
        }
    }
}
