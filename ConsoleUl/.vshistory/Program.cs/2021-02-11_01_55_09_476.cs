using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUl
{
    //SOLİD
    //O: Open Close Principle:Yaptığın yazılıma yeni bir özellik ekliyorsan mevcut koduna dokunamazsın  
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
           
        }
    }
}
