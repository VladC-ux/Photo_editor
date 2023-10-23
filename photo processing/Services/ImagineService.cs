using Photo_processing.Enum;
using Photo_processing.Repositories;
using Photo_processing.Services.Service_Interface;
using Photo_processing.Repositories.Repositrorie_Interface;
using Photo_processing.Data.Entities;
using System.Drawing;

using System.Net.Mime;

namespace Photo_processing.Services
{
    public class ImagineService : IImagineService
    {
        private readonly IImagineRepository _imagineRepository;

        public ImagineService(IImagineRepository imagineRepository)
        {
            _imagineRepository = imagineRepository;
        }

      
        public void UploadImage(Imagine image)
        {
            _imagineRepository.UploadImage(image);
        }

        public void UpdateImage(Imagine image)
        {
            _imagineRepository.UpdateImage(image);
        }

        public void DeleteImage(int imageId)
        {
            _imagineRepository.DeleteImage(imageId);
        }

      
    }


}
