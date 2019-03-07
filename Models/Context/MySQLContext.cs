using Microsoft.EntityFrameworkCore;

namespace gnv_back.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {
            
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}