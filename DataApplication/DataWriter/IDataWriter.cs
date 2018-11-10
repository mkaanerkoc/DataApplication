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
        int write(List<IWritable> dataList );
        int write(List<List<IWritable>> dataList);
    }
}
