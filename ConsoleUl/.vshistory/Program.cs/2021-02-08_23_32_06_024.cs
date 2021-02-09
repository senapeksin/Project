using System;

namespace ConsoleUl
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            Console.WriteLine("Hello World!");
        }
    }
}
