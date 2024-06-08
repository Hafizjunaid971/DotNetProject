using System.Collections.Generic;

namespace WebApiProject.Data
{
    public interface IBaseRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
      
    }
}
