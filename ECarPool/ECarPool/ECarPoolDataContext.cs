using ECarPool.Model;
using Microsoft.EntityFrameworkCore;

namespace ECarPool
{
    public class ECarPoolDataContext : DbContext
    {
        public ECarPoolDataContext(DbContextOptions<ECarPoolDataContext> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = @"
               Server=127.0.0.1,1433;
               Database=ECarPool;
               User Id=SA;
               Password=superSecure$$
            ";
            optionsBuilder.UseSqlServer(connStr);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
