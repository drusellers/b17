namespace b17.domain
{
    using System;
    using System.Collections.Generic;

    public interface Repository
    {
        IEnumerable<T> FindAll<T>();
        Tasklist GetTaskListByDate(DateTime date);
        void Save<TEntity>(TEntity obj);
        TEntity Get<TEntity>(int id) where TEntity : Identifiable;
    }
}