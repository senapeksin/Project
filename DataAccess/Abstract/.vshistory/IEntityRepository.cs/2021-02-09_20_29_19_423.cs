using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        //Generic class olusturduk.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      // List<T> GetAllByCategory(int categoryId);
    }
}
