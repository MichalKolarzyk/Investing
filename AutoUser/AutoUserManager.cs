using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;

namespace AutoUser
{
    public class AutoUserManager
    {
        readonly StdSchedulerFactory factory = new StdSchedulerFactory();
        IScheduler scheduler;

        public AutoUserManager()
        {
            Task task = Task.Run(() => scheduler = factory.GetScheduler().Result);
            task.Wait();
        }

        public void ScheduleJob(AutoJob job, Trigger trigger)
        {
            Task task = Task.Run(()=>scheduler.ScheduleJob(job.Job, trigger.BasicTrigger));
            task.Wait();
        }

        public void Start()
        {
            scheduler.Start();
        }
        public void Stop()
        {
            scheduler.Shutdown();
        }

    }
}
