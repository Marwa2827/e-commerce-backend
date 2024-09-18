using Microsoft.EntityFrameworkCore;

namespace e_commerce_backend.Models
{
    public class productContext : DbContext
    {
        public IConfiguration _config { get; set; }
        public productContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
        }

        public DbSet<product> products { get; set; } = null!;
    }
}
