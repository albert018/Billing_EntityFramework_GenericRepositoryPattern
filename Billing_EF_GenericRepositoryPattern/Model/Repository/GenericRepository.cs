using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GenericRepository<T> : IDisposable, IRepository<T> where T:class
    {
        private DbContext _Context;

        public GenericRepository(DbContext v_Value)
        {
            _Context = v_Value;
        }

        public void Create(T entity)
        {
            _Context.Set<T>().Add(entity);
            _Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _Context.Entry<T>(entity).State = EntityState.Deleted;
            _Context.SaveChanges();
        }

        public IQueryable<T> QueryAll()
        {
            return _Context.Set<T>().AsQueryable();
        }

        public T Query(Expression<Func<T, bool>> predicate)
        {
            return _Context.Set<T>().FirstOrDefault(predicate);
        }

        public void Update(T entity)
        {
            _Context.Entry<T>(entity).State = EntityState.Modified;
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
