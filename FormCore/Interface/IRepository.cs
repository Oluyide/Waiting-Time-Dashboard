using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCore.Interface
{
    public partial interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        //IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddMany(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteMany(IEnumerable<T> entities);
        void Update(T entity);
        void SaveChanges();
        T GetById(object id);
    }
}
