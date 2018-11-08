using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Models
{
    public enum DatabaseType
    {
        EXCEL_FILE,
        CSV_FILE,
        SQL_DATABASE
    }



    public class SessionModel
    {
        public BaseDevice Device { get; set; }
        public string Filename { get; set; }
        public DatabaseType DBType { get; set; }
        public double Period { get; set; }
        public List<ChannelModel> Channels { get; set; }

    }
}
