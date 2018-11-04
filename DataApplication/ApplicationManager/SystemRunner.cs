using DataApplication.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApplication.ApplicationManager
{
    public class SystemRunner
    {
        Timer       timer;
        BaseDevice  _device;

        public SystemRunner()
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;
        }

        public void SetDevice(BaseDevice deviceParam)
        {
            _device = deviceParam;
        }

        private void Timer_Tick(Object sender, EventArgs e)
        {
            
        }

        public void StartReading()
        {

        }
        public void StartFileLogging()
        {

        }
    }
}
