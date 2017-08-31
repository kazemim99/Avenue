using System;
using Avenue.Core;
using Avenue.Service.Contract.Common;

namespace Avenue.Service.Contract
{
    public interface IServicePhotoService:IEntityService<ServicePhoto>
    {
        ServicePhoto Find(Guid id);
    }
}
