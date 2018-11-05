using DataApplication.Devices;
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
        private List<BaseDevice> _devices;
        private BaseDevice _device;
        private DeviceModel _model;
        private Timer _timer;
        private bool _timerRunning = false;

        /* cagirilacak callback fonksiyonunun yapisi */
        public delegate void OnTickEventHandler(object sender, OnTickEventArgs e); 

        public event EventHandler OnTick;

        public SessionManager()
        {
            _devices = new List<BaseDevice>();
            _timer = new Timer();
            _timer.Elapsed += _timer_Elapsed;
        }

        public SessionManager( double periodParam )
        {
            _devices = new List<BaseDevice>();
            _timer = new Timer();
            _timer.Interval = periodParam;
            _timer.Elapsed += _timer_Elapsed;
        }


        public bool IsRunning()
        {
            return _timerRunning;
        }

        public void SetReadPeriod( double periodParam)
        {
            _timer.Interval = periodParam;
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

        public void AddDevice(BaseDevice deviceParam)
        {
            if(!_devices.Contains(deviceParam))
            {
                _devices.Add(deviceParam);
            }
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(_timer.AutoReset == false )
            {
                _timerRunning = false;
            }
            for(int k = 0; k < _devices.Count; k++ )
            {
                BaseDevice bd = _devices[k];
                bd.ReadDataChannels();
            }
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
