namespace b17.domain
{
    using System;
    using System.Collections.Generic;

    public class TasklistInstance
    {
        public TasklistInstance() : this(DateTime.Now)
        {
        }

        public TasklistInstance(DateTime startedOn)
        {
            StartedOn = startedOn;
            Details = new List<TaskInstance>();
        }

        public DateTime StartedOn { get; private set; }
        public IList<TaskInstance> Details { get; private set; }
    }
}