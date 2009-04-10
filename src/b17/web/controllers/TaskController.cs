namespace b17.web.controllers
{
    using domain;

    public class TaskController
    {
        Repository _repository;

        public TaskController(Repository repository)
        {
            _repository = repository;
        }

        public void New()
        {
            
        }

        public void Edit(TaskEditSetupViewModel inModel)
        {
            var task = _repository.Get<Task>(inModel.Id);
        }

        //posted to
        public ActionResultViewModel Update()
        {
            return new ActionResultViewModel() { WasSuccessful = true };
        }

        //posted to?
        public ActionResultViewModel Delete()
        {
            return new ActionResultViewModel(){WasSuccessful = true};
        }
    }

    public class TaskEditSetupViewModel
    {
        public int Id { get; set; }
    }

    public class ActionResultViewModel
    {
        public bool WasSuccessful { get; set; }
    }
}