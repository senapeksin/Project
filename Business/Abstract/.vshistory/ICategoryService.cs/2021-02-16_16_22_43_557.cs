using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        //Category ile ilgili dış dünyaya neyi servis etmek istiyorsak o operasyonları buraya yazıyoruz.

       List<Category> GetAll(); //tümünü listeler  
       Category GetById(int categoryId);


    }
}
