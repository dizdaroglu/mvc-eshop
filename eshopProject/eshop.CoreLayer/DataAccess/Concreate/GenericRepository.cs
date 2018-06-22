using eshop.CoreLayer.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eshop.CoreLayer.DataAccess.Concreate
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        protected DbContext _context;
        private DbSet<TEntity> objectSet = null;
        public GenericRepository(DbContext context)
        {
            _context = context;
            objectSet = _context.Set<TEntity>();

        }
        public void Add(TEntity entity)
        {
            if (entity!=null)
            {
                objectSet.Add(entity);  
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            return objectSet.FirstOrDefault(predicate);
        }

        public List<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? objectSet.ToList() : objectSet.Where(predicate).ToList();
        }

        public void Remove(TEntity entity)
        {
            objectSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
        }
    }
}
