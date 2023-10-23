using Photo_processing.Enum;

namespace Photo_processing.Data.Entities
{
    public class Imagine
    {
       public int Id { get; set; }
       public string Pixel { get;set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTime CreationDate { get; set; }
        public ImageEffectType ImagineEnum { get; set; }
        public User UserId { get; set; }
        

    }
}
