using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUser
{
    public class SingleTask
    {
        private Timer timer;
        public int Interval { get; set; }

        public Action Action { get; set; }

        public SingleTask(Action action, int interval)
        {
            Action = action;
            Interval = interval;
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Action?.Invoke();
        }
    }
}
