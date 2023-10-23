using Photo_processing.Enum;
using Photo_processing.Data.Entities;


namespace Photo_processing.Repositories.Repositrorie_Interface
{
    public interface IImagineRepository
    {
        void UploadImage(Imagine image);
        void UpdateImage(Imagine image);
        void DeleteImage(int imageId);
        List<ImageEffectType> GetAppliedEffects(int imageId);

    }
}
