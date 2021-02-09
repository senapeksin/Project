using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        InMemoryProductDal _inMemoryProductDal;
        public List<Product> GetAll()
        {
          //İş kodları 
          //
         
        }
    }
}
