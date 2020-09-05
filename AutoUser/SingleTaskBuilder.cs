using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUser
{
    public static class SingleTaskBuilder
    {
        public static ISimpleTaskDetail Build<T>() where T: ISingleTask
        {
            return (ISimpleTaskDetail) JobBuilder.Create<T>().Build();
        }
    }




}
