using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public interface IWritable
    {
        Type Type();
        int GetUniqueID();
        string GetAlias();
    }
}
