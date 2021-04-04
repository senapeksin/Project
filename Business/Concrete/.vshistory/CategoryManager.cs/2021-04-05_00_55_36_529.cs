using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Bu business katmanı veri erişime bağlı. Ama veri erişiminde EntityFramework olur , başka bir sey olur o yüzden bağımlılığımızı en aza indiriyoruz. Bunun için;
        //Bağımlılığımızı min indirgiyoruz.Bağımlılığımı constructor injection ile yapıyorum.

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll();
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId==categoryId);
        }
    }
}
