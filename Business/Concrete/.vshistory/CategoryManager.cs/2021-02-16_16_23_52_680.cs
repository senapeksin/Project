using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public List<Category> GetAll()
        {
            //İş kodları
            throw new NotImplementedException();
        }

        public Category GetById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
