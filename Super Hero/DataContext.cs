using Microsoft.EntityFrameworkCore;
using Super_Hero.Models;

namespace Super_Hero
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {  }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
