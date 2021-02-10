using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   //Generic class olusturduk.
    //generic constraint : generic sınırlandırma
    //class: referans tip olabilir demek
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmalı. (Yani T olarak IEntity i kullanmasını engelliyoruz .IEntity interface olduğu ve newlenemez old için kural dısı kalıyor)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// Filtre vermiyorsan; tüm datayı istiyor demektir.
        T Get(Expression<Func<T, bool>> filter); //tek bir data çağırmak için 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
