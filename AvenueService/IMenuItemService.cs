﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.Service.Contract.Common;

namespace Avenue.Service.Contract
{
    public interface IMenuItemService:IEntityService<MenuItems>
    {
        MenuItems GetById(Guid id);
    }
}
