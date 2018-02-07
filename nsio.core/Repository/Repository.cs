
using DUCore.Models;
using nsio.core.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsio.core.Services
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        private readonly NSIOContext _db = new NSIOContext();


        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _db.Set<T>();
            return query;
        }


        //public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        //{
        //    IQueryable<T> query = _db.Set<T>().Where(predicate);
        //    return query;
        //}

        public virtual void Add(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public virtual void AddMany(IEnumerable<T> entities)
        {
            _db.Set<T>().AddRange(entities);
        }

        public virtual void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public virtual void DeleteMany(IEnumerable<T> entities)
        {
            _db.Set<T>().RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            var entry = _db.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this._db.Set<T>().Attach(entity);
            }
            entry.State = EntityState.Modified;
        }

        public virtual void SaveChanges()
        {
            _db.SaveChanges();
        }


        public virtual T GetById(object id)
        {
            return _db.Set<T>().Find(id);
        }
    }
}
