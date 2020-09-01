using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutoUser
{
    public class SingleTask
    {
        private Timer timer = new Timer();
        public Action Action { get; set; }

        public SingleTask(Action action, int intervalInMilisec)
        {
            Action = action;
            timer.Interval = intervalInMilisec;
            timer.Elapsed += timerTick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Dispose()
        {
            timer.Elapsed -= timerTick;
            timer.Dispose();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Action?.Invoke();
        }
    }
}
