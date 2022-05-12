using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace CoreRepository
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity> where TEntity : class, new() where TContext : DbContext, new()
    {
        protected TContext db;

        public RepositoryBase()
        {
            db = new TContext();
        }
        public int Add(TEntity entity)
        {
            db.Add(entity);
            return db.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            db.Remove(entity);
            return db.SaveChanges();
        }

        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<TEntity>().ToList();
            }
            else
            {
                return db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id); 
        }

        public int Update(TEntity entity)
        {
            var AddEntity = db.Entry(entity);
            AddEntity.State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}