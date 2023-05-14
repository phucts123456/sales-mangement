using Microsoft.AspNetCore.Http;

namespace SaleManagementDAL.Serivces.Photo.Interfaces
{
    public interface IPhotoAccessor
    {
        Task<PhotoUploadResult> AddPhoto(IFormFile file);
        PhotoUploadResult AddPhotoSyn(string filePath);
        Task<string> DeletePhoto(string publicId);
    }
}
