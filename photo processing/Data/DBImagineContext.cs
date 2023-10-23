using Microsoft.EntityFrameworkCore;
using Photo_processing.Data.Entities;

namespace Photo_processing.Data
{
    public class DBImagineContext : DbContext
    {
        
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AppliedEffect> AppliedEffects { get; set; }

    }
}
