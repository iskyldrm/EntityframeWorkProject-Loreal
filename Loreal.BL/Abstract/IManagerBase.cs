using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.BL.Abstract
{
    public interface IManagerBase<TEntity> where TEntity : class, new()
    {
        public int Add(TEntity entity);
        public int Update(TEntity entity);
        public int Delete(TEntity entity);
        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        public TEntity GetById(int id);
    }
    
}
