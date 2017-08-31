using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;

namespace Avenue.Service
{
  public class ScoreService:EntityService<Score>,IScoreService
    {
      public ScoreService(IContext context) : base(context)
      {
          _DbSet = context.Set<Score>();
      }

      public Score GetById(Guid id)
      {
          return _DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
      }
    }
}
