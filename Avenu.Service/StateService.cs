using System;
using System.Data.Entity;
using System.Linq;
using Avenue.Core;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;

namespace Avenue.Service
{
    public class StateService : EntityService<State>, IStateService
    {
        public StateService(IContext context) : base(context)
        {
            _DbSet = context.Set<State>();
        }

        public State Find(Guid id)
        {
          
                return _DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

      
    }
}