using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Avenue.Core;
using Avenue.DTO;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;

namespace Avenue.Service
{
    public class WeddingVenuesService : EntityService<WeddingVenues>, IWeddingVenuesService
    {
        public WeddingVenuesService(IContext context) : base(context)
        {
            _DbSet = context.Set<WeddingVenues>();
        }


        public Guid Insert(WeddingVenues model)
        {
            var result = _DbSet.Add(model);
            _Context.SaveChanges();
            return result.Id;
        }

        public List<SelectListItem> FacilityListItems()
        {
            var facilityId = _DbSet.ToList();

            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var item in facilityId)
            {
               items.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            return items;
        }

    
    }
}