using FN.Store.Domain.Contracts;
using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : Entity
    {

        protected readonly FNStoreDataContext _ctx =
            new FNStoreDataContext();

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
            save();
        }

        private void save()
        {
            //Log();
            _ctx.SaveChanges();
        }

        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            save();
        }

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>().ToList();
        }

        public T Get(object id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _ctx.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            save();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
