namespace b17.domain
{
    using System;

    public class Task :
        Identifiable
    {
        public int Id { get; private set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Employee SignedOffBy { get; set; }
    }
}