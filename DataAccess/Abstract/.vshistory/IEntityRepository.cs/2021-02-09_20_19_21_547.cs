using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        void Add(T product);
        void Update(T product);
        void Delete(T product);

        List<T> GetAllByCategory(int categoryId);
    }
}
