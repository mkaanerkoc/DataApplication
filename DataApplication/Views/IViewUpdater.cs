using DataApplication.DataWriter;
using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.View
{
    public interface IViewUpdater
    {
        int initialize(List<ChannelModel> channelList);
        int addChannel(ChannelModel newChannel);
        int removeChannel(ChannelModel oldChannel);
        int update(List<IWritable> dataList);
        // buna simdilik gerek yok int update(List<List<IWritable>> dataList);
    }
}
