using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace Core.DataAccess.EntityFramework
{
    //EfEntityRepositoryBase : Evrensel bir kod. EntityFramework kullanarak bir repository base i olustur demek.
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext : DbContext , new ()
    {

    }
}
