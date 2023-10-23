using Microsoft.EntityFrameworkCore;
using Photo_processing.Data;
using Photo_processing.Data.Entities;
using Photo_processing.Enum;
using Photo_processing.Repositories.Repositrorie_Interface;

namespace Photo_processing.Repositories
{
    public class ImagineRepository : IImagineRepository
    {
        private readonly DBImagineContext _dbContext;

        public ImagineRepository(DBImagineContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteImage(int imageId)
        {
            var image = _dbContext.Images.FirstOrDefault(i => i.Id == imageId);
            if (image != null)
            {
                _dbContext.Images.Remove(image);
                _dbContext.SaveChanges();
            }
        }

        public List<ImageEffectType> GetAppliedEffects(int imageId)
        {
            var appliedEffects = _dbContext.AppliedEffects
                .Where(e => e.ImageId == imageId)
                .Select(e => e.EffectType)
                .ToList();

            return appliedEffects;
        }

        public void UpdateImage(Image image)
        {
            _dbContext.Images.Update(image);
            _dbContext.SaveChanges();
        }

        public void UploadImage(Image image)
        {
            _dbContext.Images.Add(image);
            _dbContext.SaveChanges();
        }
    }
}