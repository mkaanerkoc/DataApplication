using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApplication.DataWriter;
using DataApplication.Views;
using System.Drawing;
using DataApplication.Devices;

namespace DataApplication.View
{
    public class FormUpdater : IViewUpdater
    {
        private List<DataWindow> dtList;
        private Control container;
        public FormUpdater( GroupBox containerParam )
        { 
            container = containerParam;
            dtList = new List<DataWindow>();
        }

        public int initialize(List<ChannelModel> channelList)
        {
            dtList.Clear();
            container.Controls.Clear();
            DataWindow dt = new DataWindow();
            for(int k = 0; k < channelList.Count;k++)
            {
                dtList.Add(new DataWindow(channelList[k].name, channelList[k].unit));
            }
            int viewInRow = container.Size.Width / dt.Size.Width;
            for (int k = 0; k < dtList.Count; k++)
            {
                var i = dtList[k];
                int yPos = (k / viewInRow) * i.Size.Height;
                int xPos = (k % viewInRow) * i.Size.Width;
                i.Location = new Point(10 + xPos, 15 + yPos);
                container.Controls.Add(i);
            }
            return 1;
        }
        public int update(List<IWritable> dataList)
        {
            int retval = 0;
            foreach( var i in dataList )
            {
                var k = dtList.Where(x => x.Alias.Equals(i.GetAlias())).FirstOrDefault();
                if( k != null )
                {
                    if(k.InvokeRequired)
                    {
                        k.Invoke( new MethodInvoker(() => {
                            k.Value = i.ToString();
                        }));
                    }
                    else
                    {
                        k.Value = i.ToString();
                    }
                }
            }
            return retval;
        }

        public int update(List<List<IWritable>> dataList)
        {
            throw new NotImplementedException();
        }
        
    }
}
