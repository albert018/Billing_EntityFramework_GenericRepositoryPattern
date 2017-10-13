using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T>
    {
        void Create(T entity);
        T Query(Expression<Func<T, bool>> predicate);
        IQueryable<T> QueryAll();
        void Update(T entity);
        void Delete(T entity);
        //void SaveChanges();
    }

}
