using DataApplication.Devices;
using DataApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public interface IDataWriter
    {
        int create();
        int create(string nameParam);
        int open();
        int open(string nameParam);
        int close();
        int writeHeader(List<ChannelModel> channels, OperatorModel operatorParam, FacilityModel facilityParam);
        int write(List<IWritable> dataList );
        int write(List<List<IWritable>> dataList);
    }
}
