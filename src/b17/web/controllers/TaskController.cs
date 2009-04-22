namespace b17.web.controllers
{
    using System;
    using domain;

    public class TaskController
    {
        Repository _repository;

        public TaskController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResultViewModel New()
        {
            Task t = new Task();
            _repository.Save(t);
            return new ActionResultViewModel()
            {
                Task = t,
                WasSuccessful = true
            };
        }

        public ActionResultViewModel Edit(TaskEditSetupViewModel inModel)
        {
            var task = _repository.Get<Task>(inModel.Id);

            

            return new ActionResultViewModel()
            {
                Task = task,
                WasSuccessful = true
            };
        }

        //posted to
        public ActionResultViewModel Update(TaskEditSubmitViewModel inModel)
        {
            var t = _repository.Get<Task>(inModel.Id);

            //edit

            _repository.Save(t);

            return new ActionResultViewModel()
                   {
                       Task =  t,
                       WasSuccessful = true
                   };
        }

        //posted to?
        public ActionResultViewModel Delete(TaskEditSetupViewModel inModel)
        {
            _repository.Delete<Task>(inModel.Id);
            return new ActionResultViewModel(){WasSuccessful = true};
        }

        public void List()
        {
            var x = _repository.FindAll<Task>();

        }
    }

    public class TaskEditSetupViewModel
    {
        public Guid Id { get; set; }
    }
    public class TaskEditSubmitViewModel
    {
        public Guid Id { get; set; }
    }

    public class ActionResultViewModel
    {
        public Task Task { get; set; }
        public bool WasSuccessful { get; set; }
    }
}