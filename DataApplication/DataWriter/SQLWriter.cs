using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataApplication.Devices;
using DataApplication.Models;

namespace DataApplication.DataWriter
{
    public class SQLWriter : IDataWriter
    {

        public int create()
        {
            throw new NotImplementedException();
        }

        public int create(string nameParam)
        {
            throw new NotImplementedException();
        }

        public int open()
        {
            throw new NotImplementedException();
        }

        public int open( string nameParam)
        {
            throw new NotImplementedException();
        }

        public int close()
        {
            throw new NotImplementedException();
        }

        public int write(List<IWritable> dataList)
        {
            throw new NotImplementedException();
        }

        public int write(List<List<IWritable>> dataList)
        {
            throw new NotImplementedException();
        }

        public int writeHeader(List<ChannelModel> channels, OperatorModel operatorParam, FacilityModel facilityParam)
        {
            throw new NotImplementedException();
        }
    }
}
