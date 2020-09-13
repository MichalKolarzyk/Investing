using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoUser
{
    public class Scheduler
    {
        private IScheduler scheduler;
        private List<ApplicationJob> applicationJobs = new List<ApplicationJob>();

        public Scheduler()
        {
            StdSchedulerFactory factory = new StdSchedulerFactory();
            Task<IScheduler> task = factory.GetScheduler();
            Task.WaitAll(task);
            scheduler = task.Result;
        }

        public void Add(ApplicationJob applicationJob)
        {
            applicationJobs.Add(applicationJob);
        }

        public async Task Start()
        {
            foreach(ApplicationJob applicationJob in applicationJobs)
            {
                await scheduler.ScheduleJob(applicationJob.GetJob(), applicationJob.GetTrigger());
            }
            await scheduler.Start();
        }

        public async Task ShutDown()
        {
            await scheduler.Shutdown();
        }
    }
}
