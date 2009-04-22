namespace b17.domain
{
    using System;
    using System.Linq;

    /// <summary>
    /// Contains the process to go from the abstract list to the instance list
    /// </summary>
    public class GenerateNewTasklistInstance
    {
        readonly Repository _repository;

        public TasklistInstance Build()
        {
            var tl = new TasklistInstance();

            _repository.FindAll<Task>()
                .Select((t, i) => new TaskInstance {Name = t.Name, Description = t.Description, SignedOffBy = t.SignedOffBy})
                .Each(td => tl.Details.Add(td));

            return tl;
        }
        public TasklistInstance FindOrCreate(DateTime date)
        {
            return _repository.FindOrCreateTaskListByDate(date);
        }
    }
}