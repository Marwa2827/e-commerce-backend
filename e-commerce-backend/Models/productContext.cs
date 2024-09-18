using Microsoft.EntityFrameworkCore;

namespace e_commerce_backend.Models
{
    public class productContext : DbContext
    {
        public productContext(DbContextOptions<productContext> options)
        : base(options)
        {
        }

        public DbSet<product> products { get; set; } = null!;
    }
}
