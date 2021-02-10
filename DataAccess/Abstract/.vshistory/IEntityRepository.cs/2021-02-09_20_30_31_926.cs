using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        //Generic class olusturduk.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(); //tek bir kayıt getirmek için kullanıcaz. Filtre vermiyorsan; tüm datayı istiyor demektir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      // List<T> GetAllByCategory(int categoryId);
    }
}
