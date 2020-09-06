using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUser
{
    class SimpleTask : ISingleTask
    {
        public Action TaskMethod { get; set; }

        public SimpleTask() { }
        public SimpleTask(Action taskMethod)
        {
            TaskMethod = taskMethod;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(TaskMethod);
        }
    }
}
