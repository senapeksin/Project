using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Database tabloları ile proje classlarını bağlamak.(Veritabanı ile kendi classlarımızı ilişkilendirdiğimiz classımızdır.)
    //DbSet: Hangi nesne hangi veritabanındaki tabloya karsılık gelecek onu belirtmek için kullanırız.
    public class NorthwindContext:DbContext
    {
        //OnConfiguring : Projenin hangi veritabanı ile ilişkili olduğunu belirttiğimiz yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
         }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
