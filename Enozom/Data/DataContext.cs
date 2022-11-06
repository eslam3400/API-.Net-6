using Enozom.Model;
using Microsoft.EntityFrameworkCore;

namespace Enozom.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed.Hotels(modelBuilder);
            Seed.HotelPrices(modelBuilder);
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelPrices> HotelPrices { get; set; }
    }
}
