namespace b17.specs
{
    using web.controllers;

    public class TasklistController_specs
    {
        TasklistController tlc = new TasklistController();

        public void New_tasklist()
        {
            tlc.New();
        }

        public void Update_tasklist()
        {
            tlc.Update();
        }

        public void Delete_tasklist()
        {
            tlc.Delete();
        }

        public void List_tasklist()
        {
            tlc.List();
        }


    }
}