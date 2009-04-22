namespace b17.domain
{
    using System;

    /// <summary>
    /// This is the abstract task that you create instances of 'TaskInstance'
    /// </summary>
    public class Task :
        Identifiable
    {
        public Task()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Employee SignedOffBy { get; set; }
    }
}