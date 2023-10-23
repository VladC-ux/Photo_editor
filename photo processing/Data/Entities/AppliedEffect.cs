using Photo_processing.Enum;

namespace Photo_processing.Data.Entities
{
    public class AppliedEffect
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public ImageEffectType EffectType { get; set; }
    }
}
