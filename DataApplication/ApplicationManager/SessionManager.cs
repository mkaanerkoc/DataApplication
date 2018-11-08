using DataApplication.Devices;
using DataApplication.Models;
using DataApplication.Peripherals.MockDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DataApplication.ApplicationManager
{
    public class SessionManager
    {
        public SessionModel userInfo;
        private Timer _timer;
        private bool _timerRunning = false;

        public List<ChannelModel> selectedChannels { get; set; }


        /* cagirilacak callback fonksiyonunun yapisi */
        public delegate void OnTickEventHandler(object sender, OnTickEventArgs e); 

        public event EventHandler OnTick;

        public SessionManager()
        {
            userInfo = new SessionModel();
            _timer = new Timer();
            _timer.Elapsed += _timer_Elapsed;
        }

        public SessionManager( double periodParam )
        {
            userInfo = new SessionModel();
            _timer = new Timer();
            _timer.Interval = periodParam;
            _timer.Elapsed += _timer_Elapsed;
        }


        public bool IsRunning()
        {
            return _timerRunning;
        }

        

        public void StartTimer()
        {
            _timer.Close();
            _timer.Start();
            _timerRunning = true;
        }
        public void StopTimer()
        {
            _timer.Stop();
            _timerRunning = false;
        }

        public void SetDevice(BaseDevice deviceParam)
        {
            userInfo.Device = deviceParam;
        }

        public void SetReadPeriod(double periodParam)
        {
            _timer.Interval = periodParam;
        }

        public void SetActiveChannels( List<ChannelModel> channelsParam )
        {
            userInfo.Channels = channelsParam;
        }

        public void SetFilename( string filenameParam )
        {
            userInfo.Filename = filenameParam;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(_timer.AutoReset == false )
            {
                _timerRunning = false;
            }

            userInfo.Device.ReadDataChannels();
            
            OnTickEventArgs ee = new OnTickEventArgs();
            ee.TimeReached = DateTime.Now;
            OnTick?.Invoke(this, ee);
        }

        /*protected virtual void OnTick(OnTickEventArgs e)
        {
            e.TimeReached = DateTime.Now;
            
        }*/


    }

    public class OnTickEventArgs : EventArgs
    {
        public int Result { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
