using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint : generic sınırlandırma
    //class: referans tip olabilir demek
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    public interface IEntityRepository<T> where T:class,IEntity
    {
        //Generic class olusturduk.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// Filtre vermiyorsan; tüm datayı istiyor demektir.
        T Get(Expression<Func<T, bool>> filter); //tek bir data çağırmak için 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
