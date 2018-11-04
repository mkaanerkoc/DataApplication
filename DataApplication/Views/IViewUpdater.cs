using DataApplication.DataWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.View
{
    public interface IViewUpdater
    {
        int update(List<WritableBase> dataList);
        int update(List<List<WritableBase>> dataList);
    }
}
