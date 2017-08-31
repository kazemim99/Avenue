using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Avenue.Core.Common;
using Avenue.InfraStructure;

namespace Avenue.Service.Contract.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {

        protected IContext _Context;
        protected IDbSet<T> _DbSet;

        protected EntityService(IContext context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _Context.Entry(entity).State = EntityState.Added;
            _Context.SaveChanges();

        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _DbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Deleted;
            _Context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _DbSet.AsQueryable();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _DbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Modified;
            _Context.SaveChanges();
        }

        public T Find(Guid id)
        {
           return _DbSet.Find(id);
        } 
         
      
    }
}
