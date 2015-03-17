using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Timers;
using SignalMVC.Hubs;


namespace SignalMVC.Models
{
    public class VideoTimer
    {
        private Timer _timer;

        public void Start(int seconds)
        {
            _timer = new Timer(seconds * 1000);
            _timer.Elapsed += TimerDone;
            _timer.Start();
        }

        private void TimerDone(Object source, ElapsedEventArgs e)
        {
            this.Stop();

        }

        public void Stop()
        {
            _timer.Stop();
        }

    }
}