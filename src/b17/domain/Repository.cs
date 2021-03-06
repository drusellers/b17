namespace b17.domain
{
    using System;
    using System.Collections.Generic;

    public interface Repository
    {
        IEnumerable<T> FindAll<T>();
        TasklistInstance FindOrCreateTaskListByDate(DateTime date);
        void Save<TEntity>(TEntity obj);
        TEntity Get<TEntity>(Guid id) where TEntity : Identifiable;
        void Delete<TEntity>(Guid id) where TEntity : Identifiable;
    }
}