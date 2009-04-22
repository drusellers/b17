namespace b17.web.controllers
{
    using System;
    using System.Linq;
    using domain;

    public class TodayController
    {
        readonly Repository _repository;

        public TodayController(Repository repository)
        {
            _repository = repository;
        }

        public TodayViewModel Index(TodaySetupViewModel inModel)
        {
            var todaysTasks = _repository.FindOrCreateTaskListByDate(DateTime.Today);
            
            var outm = new TodayViewModel {TaskList = todaysTasks};

            return outm;
        }
    }

    public class TodaySetupViewModel {}

    [Serializable]
    public class TodayViewModel
    {
        public TasklistInstance TaskList { get; set; }
    }
}