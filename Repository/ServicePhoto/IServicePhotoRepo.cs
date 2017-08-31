using Avenue.DTO;

namespace Avenu.Repository.ServicePhoto
{
   public interface IServicePhotoRepo:IBaseRepo<ServicePhotoDto>
   {

     void  DeleteByModel(ServicePhotoDto model);
   }
}
