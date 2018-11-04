using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public class ExcelWriter : IDataWriter
    {
        
        public int open( string nameParam)
        {
            throw new NotImplementedException();
        }

        public int close()
        {
            throw new NotImplementedException();
        }
        
        public int write(List<WritableBase> dataList)
        {
            throw new NotImplementedException();
        }

        public int write(List<List<WritableBase>> dataList)
        {
            throw new NotImplementedException();
        }
    }
}
