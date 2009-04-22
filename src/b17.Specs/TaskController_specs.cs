namespace b17.specs
{
    using System;
    using System.Collections.Generic;
    using domain;
    using NUnit.Framework;
    using Rhino.Mocks;
    using web.controllers;

    public class TaskController_specs
    {
        TaskController tlc;
        Repository repository;

        public void SetUp()
        {
            repository = MockRepository.GenerateStub<Repository>();
            tlc = new TaskController(repository);
        }

        public void New_tasklist()
        {
            repository.Expect(x => x.Save(new Task())).IgnoreArguments();
            tlc.New();

            repository.VerifyAllExpectations();
        }
    }

    [TestFixture]
    public class TaskController_edit_specs
    {
        TaskController tlc;
        Repository repository;
        Guid _id;
        TaskEditSetupViewModel inModel;
        TaskEditSubmitViewModel updateInModel;
        Task task;

        [SetUp]
        public void SetUp()
        {
            task = new Task()
                       {
                           Name = "test"
                       };
            _id = task.Id;
            inModel = new TaskEditSetupViewModel(){Id = _id};
            updateInModel = new TaskEditSubmitViewModel(){Id = _id};
            repository = MockRepository.GenerateMock<Repository>();
            repository.Stub(x => x.Get<Task>(_id)).Return(task);
            tlc = new TaskController(repository);
        }

        [TearDown]
        public void TearDown()
        {
            repository.VerifyAllExpectations();
        }
        
        [Test]
        public void Edit_task()
        {
            var a = tlc.Edit(inModel);
            a.Task.Name.ShouldEqual("test");
        }

        [Test]
        public void Update_tasklist()
        {
            repository.Expect(x => x.Save(task));
            tlc.Update(updateInModel);
        }

        [Test]
        public void Delete_tasklist()
        {
            repository.Expect(x => x.Delete<Task>(_id));
            tlc.Delete(inModel);
        }

        [Test]
        public void List_tasklist()
        {
            repository.Expect(x => x.FindAll<Task>()).Return(new List<Task>());
            tlc.List();
        }
    }
}