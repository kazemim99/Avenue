using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.DTO;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;
using Avenue.ViewModels;

namespace Avenue.Service
{
    public class CityService : EntityService<City>, ICityService
    {
        public CityService(IContext context) : base(context)
        {
        }
    }
}