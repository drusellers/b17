namespace b17.web.controllers
{
    using System;
    using System.Linq;
    using display_models;
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
            var todaysTasks = _repository.GetTaskListByDate(DateTime.Today);
            var todaysList = new TaskListForDisplay {StartedOn = todaysTasks.StartedOn};

            todaysTasks.Details.Each(td => todaysList.Tasks.Add(new TaskDetailForDisplay()
                                                                {
                                                                    Name = td.Name,
                                                                    Description = td.Description,
                                                                }));

            var outm = new TodayViewModel {TaskList = todaysList};

            return outm;
        }
    }

    public class TodaySetupViewModel {}

    [Serializable]
    public class TodayViewModel
    {
        public TaskListForDisplay TaskList { get; set; }
    }
}