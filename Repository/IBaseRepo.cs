using System;
using System.Collections.Generic;

namespace Avenu.Repository
{
    public interface IBaseRepo<T>
    {
        IEnumerable<T> GetAll();
        void Create(T model);
        void Edit(T model);
        void Delete(Guid id);
        T Find(Guid id);


    }
}
