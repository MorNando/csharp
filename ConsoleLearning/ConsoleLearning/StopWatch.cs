using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    class StopWatch
    {
        private DateTime _starttime = new DateTime();
        private DateTime _stoptime = new DateTime();
        public TimeSpan TotalTime = new TimeSpan();

        public DateTime Start()
        {
            _starttime = DateTime.Now;
            return _starttime;
        }

        public TimeSpan Stop()
        {
            _stoptime = DateTime.Now;
            
            TotalTime = _stoptime - _starttime;
            return TotalTime;
        }
    }
}
