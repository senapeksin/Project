using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Database tabloları ile proje classlarını bağlamak.(Veritabanı ile kendi classlarımızı ilişkilendirdiğimiz classımızdır.)
    public class NorthwindContex:DbContext
    {
        //OnConfiguring : Projenin hangi veritabanı ile ilişkili olduğunu belirttiğimiz yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
         }

    }
}
