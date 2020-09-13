using Quartz;
using System;

namespace AutoUser
{
    public class ApplicationJob
    {
        public string CronExpression { get; set; }
        JobDataMap jobDataMap = new JobDataMap();
        public ApplicationJob(string cronExpression, params Action[] actions)
        {
            CronExpression = cronExpression;
            setupJobDataMap(actions);
        }

        private void setupJobDataMap(Action[] actions)
        {
            foreach(Action action in actions)
            {
                jobDataMap.Add(jobDataMap.Count.ToString(), action);
            }
        }

        internal IJobDetail GetJob()
        {
            IJobDetail job = JobBuilder.Create<JobHandler>()
                .UsingJobData(jobDataMap)
                .Build();
            return job;
        }

        internal ITrigger GetTrigger()
        {
            ITrigger trigger = TriggerBuilder.Create()
                .WithCronSchedule(CronExpression)
                .Build();
            return trigger;
        }
    }
}