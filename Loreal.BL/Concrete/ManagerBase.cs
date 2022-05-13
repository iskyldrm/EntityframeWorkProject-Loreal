using Loreal.BL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.BL.Concrete
{
    public class ManagerBase<TEntity, TContext> : IManagerBase<TEntity> where TEntity : class, new() where TContext:DbContext ,new()
    {
        protected TContext db;

        public ManagerBase()
        {
            db = new TContext();
        }
        public virtual int Add(TEntity entity)
        {
            
            return db.SaveChanges();
        }

        public virtual int Delete(TEntity entity)
        {
            db.Remove(entity);
            return db.SaveChanges();
        }

        public virtual IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
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

        public virtual TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public virtual int Update(TEntity entity)
        {
            var AddEntity = db.Entry(entity);
            AddEntity.State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
