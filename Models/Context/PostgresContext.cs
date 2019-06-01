using Microsoft.EntityFrameworkCore;

namespace gnv_back.Models.Context
{
    public class PostgresContext : DbContext
    {
        public PostgresContext() {

        }

        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) {
            
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}