using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eshop.CoreLayer.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        List<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate = null);

        TEntity Find(Expression<Func<TEntity, bool>> predicate);


        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Update(TEntity entity);






    }
}
