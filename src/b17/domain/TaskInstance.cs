namespace b17.domain
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class TaskInstance
    {
        public int TaskId { get; set; }
        public int TaskVersion { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Employee SignedOffBy { get; set; }
        public Employee CompletedBy { get; set; }
        public DateTime CompletedOn { get; set; }
    }
}