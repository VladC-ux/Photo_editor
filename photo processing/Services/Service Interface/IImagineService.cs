using Photo_processing.Enum;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using Photo_processing.Data.Entities;

namespace Photo_processing.Services.Service_Interface
{
    public interface IImagineService
    {
       
        void UploadImage(Imagine image);
        void UpdateImage(Imagine image);
        void DeleteImage(int imageId);
      
      
    }
}
