using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace AutoUser
{
    class JobHandler : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            foreach (var job in context.JobDetail.JobDataMap.Values)
            {
                if (job is Action action)
                {
                    await Task.Run(() => action.Invoke());
                }
            }
        }
    }
}
