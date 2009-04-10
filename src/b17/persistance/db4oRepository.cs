namespace b17.persistance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Db4objects.Db4o;
    using Db4objects.Db4o.Linq;
    using domain;

    public class db4oRepository :
        Repository
    {
        readonly IObjectContainer _container;

        public db4oRepository(IObjectContainer container)
        {
            _container = container;
        }


        public IEnumerable<TEntity> FindAll<TEntity>()
        {
            return from TEntity entity in _container
                   select entity;
        }

        public Tasklist GetTaskListByDate(DateTime date)
        {
            return (from Tasklist t in _container
                    where t.StartedOn == date
                    select t).First();
        }

        public void Save<TEntity>(TEntity obj)
        {
            _container.Store(obj);
        }

        public TEntity Get<TEntity>(Guid id) where TEntity : Identifiable
        {
            return (from TEntity o in _container
                    where o.Id == id
                    select o).First();
        }
    }
}