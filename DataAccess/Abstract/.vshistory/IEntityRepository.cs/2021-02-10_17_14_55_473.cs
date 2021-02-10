using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        //Generic class olusturduk.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// Filtre vermiyorsan; tüm datayı istiyor demektir.
        T Get(Expression<Func<T, bool>> filter); //tek bir data çağırmak için 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
