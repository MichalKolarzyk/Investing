using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUser
{
    public class Schedule
    {
        public List<SingleTask> Tasks { get; set; } = new List<SingleTask>();
        public Schedule() { } 

        public void Start()
        {
            foreach(SingleTask task in Tasks)
            {
                task.Start();
            }
        }

        public void Stop()
        {
            foreach(SingleTask task in Tasks)
            {
                task.Stop();
            }
        }

        public void Dispose()
        {
            foreach (SingleTask task in Tasks)
            {
                task.Dispose();
            }
        }

        public void Add(SingleTask task)
        {
            Tasks.Add(task);
        }

    }
}
