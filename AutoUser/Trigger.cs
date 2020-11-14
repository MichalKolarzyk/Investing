using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUser
{
    public class Trigger
    {
        //public string CornSchedule { get; set; } = "0 * 15-22 ? * MON-FRI";
        public string CornSchedule { get; set; } = "0 * 8-22 ? * *";
        internal ITrigger BasicTrigger
        {
            get
            {
                return TriggerBuilder.Create()
                    .WithCronSchedule(CornSchedule)
                    .Build();
            }
        }
    }
}
