using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit.Data;

namespace LimitlessCareWebsite.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext dbcontext;

        public Repository(ApplicationContext context)
        {
            dbcontext = context;
        }

        protected virtual IQueryable<TEntity> AsQueryable()
        {
            return dbcontext.Set<TEntity>();
        }

        protected virtual void Delete(TEntity entity)
        {
            dbcontext.Set<TEntity>().Remove(entity);
        }

        protected virtual void Insert(TEntity entity)
        {
            dbcontext.Set<TEntity>().Add(entity);
        }

        protected virtual void Update(TEntity entity)
        {
            dbcontext.Entry(entity).State = EntityState.Modified;
        }
    }
}
