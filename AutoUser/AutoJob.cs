using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUser
{
    public class AutoJob
    {
        internal JobDataMap jobDataMap = new JobDataMap();
        internal IJobDetail Job
        {
            get
            {
                return JobBuilder.Create<AdvancedJob>()
                    .UsingJobData(jobDataMap)
                    .Build();
            }
        }
        public void AddAction(Action action)
        {
            jobDataMap.Add(jobDataMap.Count.ToString(), action);
        }
    }
}
