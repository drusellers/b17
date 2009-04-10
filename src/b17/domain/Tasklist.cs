namespace b17.domain
{
    using System;
    using System.Collections.Generic;

    public class Tasklist
    {
        public Tasklist()
        {
            StartedOn = DateTime.Now;
            Details = new List<TaskDetail>();
        }

        public DateTime StartedOn { get; private set; }
        public IList<TaskDetail> Details { get; private set; }
    }
}