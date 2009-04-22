namespace b17.specs
{
    using System;
    using System.IO;
    using System.Linq;
    using Db4objects.Db4o;
    using domain;
    using NUnit.Framework;
    using persistance;

    [TestFixture]
    public class db4oRepository_specs
    {

        [Test]
        public void NAME()
        {
            if(File.Exists("test.db")) File.Delete("test.db");
            IObjectContainer container = Db4oFactory.OpenFile("test.db");

            db4oRepository repo = new db4oRepository(container);
            var id = Guid.NewGuid();
            repo.Save(new Bob{Id = id, Name = "dru"});
            var b = repo.Get<Bob>(id);
            b.Name.ShouldEqual("dru");

            //find all
            var e = repo.FindAll<Bob>();
            e.Count().ShouldEqual(1);

            //delete
            repo.Delete<Bob>(id);
            var e2 = repo.FindAll<Bob>();
            e2.Count().ShouldEqual(0);
        }
    }

    public class Bob : Identifiable
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}