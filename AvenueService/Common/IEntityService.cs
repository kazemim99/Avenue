using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Service.Contract.Common
{
    public interface IEntityService<T>:IService
        where T:BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        void Update(T entity);
        T Find(Guid id);
    }
}
