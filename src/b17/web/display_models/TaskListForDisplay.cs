namespace b17.web.display_models
{
    using System;
    using System.Collections.Generic;

    public class TaskListForDisplay
    {
        public TaskListForDisplay()
        {
            Tasks = new List<TaskDetailForDisplay>();
        }

        public DateTime StartedOn { get; set; }
        public IList<TaskDetailForDisplay> Tasks { get; private set; }
    }
}