using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace AutoUser
{
    public class Schedule
    {
        private IScheduler scheduler;

        public Schedule()
        {
            StdSchedulerFactory factory = new StdSchedulerFactory();
            scheduler = factory.GetScheduler().Result;
        }

        public void Add(IJobDetail singleTask, ITaskTrigger taskTrigger)
        {
            Task.WaitAll(scheduler.ScheduleJob(singleTask, taskTrigger));
        }

        public void Start()
        {
            scheduler.Start();
        }

        public void Stop()
        {
            scheduler.Standby();
        }

        public void ShutDown()
        {
            scheduler.Shutdown();
        }


    }
}
