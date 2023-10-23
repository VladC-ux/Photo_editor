namespace Photo_processing.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public List<Image> Images { get; set; }
    }
}
