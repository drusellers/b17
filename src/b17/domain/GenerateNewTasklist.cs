namespace b17.domain
{
    using System.Linq;

    public class GenerateNewTasklist
    {
        readonly Repository _repository;

        public Tasklist Build()
        {
            var tl = new Tasklist();

            _repository.FindAll<Task>()
                .Select((t, i) => new TaskDetail {Name = t.Name, Description = t.Description, SignedOffBy = t.SignedOffBy})
                .Each(td => tl.Details.Add(td));

            return tl;
        }
    }
}