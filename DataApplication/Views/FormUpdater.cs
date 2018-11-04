using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApplication.DataWriter;
using DataApplication.Views;
using System.Drawing;

namespace DataApplication.View
{
    public class FormUpdater : IViewUpdater
    {
        private List<DataWindow> dtList;
        private Control container;
        public FormUpdater( GroupBox containerParam )
        { 
            container = containerParam;
            initialize();
        }
        private void initialize()
        {
            dtList = new List<DataWindow>();
            dtList.Add(new DataWindow("channel1", "mc2"));
            dtList.Add(new DataWindow("channel2", "co2"));
            dtList.Add(new DataWindow("channel3", "co"));
            dtList.Add(new DataWindow("channel4", "mg2"));
            dtList.Add(new DataWindow("channel5", "ph"));
            dtList.Add(new DataWindow("channel6", "ph"));
            dtList.Add(new DataWindow("channel7", "ph"));
            int viewInRow = container.Size.Width / dtList[0].Size.Width;
            for (int k = 0; k < dtList.Count; k++)
            {
                var i = dtList[k];
                int yPos = (k / viewInRow) * i.Size.Height;
                int xPos = (k % viewInRow) * i.Size.Width;
                i.Location = new Point(10 + xPos, 15 + yPos);
                container.Controls.Add(i);
            }
        }
        public int update(List<WritableBase> dataList)
        {
            int retval = 0;
            foreach( var i in dataList )
            {
                var k = dtList.Where(x => x.Alias.Equals(i.alias)).FirstOrDefault();
                k.Value = i.ToString();
            }
            return retval;
        }

        public int update(List<List<WritableBase>> dataList)
        {
            throw new NotImplementedException();
        }
    }
}
