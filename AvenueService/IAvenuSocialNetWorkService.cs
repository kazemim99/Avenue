
using Avenue.Core;
using Avenue.Service.Contract.Common;

namespace Avenue.Service.Contract
{
    interface IAvenuSocialNetWorkService:IEntityService<Social>
    {
        Social GetById(int id);
    }
}
