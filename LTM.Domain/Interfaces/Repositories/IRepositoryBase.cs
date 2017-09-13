using System.Collections.Generic;

namespace LTM.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> Getall();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
