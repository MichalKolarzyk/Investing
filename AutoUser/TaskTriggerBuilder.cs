using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.Impl;
using Quartz;

namespace AutoUser
{
    public class TaskTriggerBuilder
    {
        public ITaskTrigger Build(DateTimeOffset startAt, DateTimeOffset endAt, int intervalInSeconds)
        {
            return (ITaskTrigger)TriggerBuilder.Create()
                .StartAt(startAt)
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(intervalInSeconds)
                    .RepeatForever())
                .EndAt(endAt)
                .Build();
        }
    }
}
