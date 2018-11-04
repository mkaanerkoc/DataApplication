using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public interface IDataWriter
    {
        int open(string nameParam);
        int close();
        int write(List<WritableBase> dataList );
        int write(List<List<WritableBase>> dataList);
    }
}
