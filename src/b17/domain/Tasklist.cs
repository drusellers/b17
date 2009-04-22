namespace b17.domain
{
    using System.Collections.Generic;

    public class Tasklist
    {
        public Tasklist()
        {
            Tasks =new List<Task>();
        }

        public string Name { get; set; }
        public IList<Task> Tasks { get; private set; }
    }
}