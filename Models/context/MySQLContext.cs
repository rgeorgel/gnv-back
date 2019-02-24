using Microsoft.EntityFrameworkCore;

namespace gnv_back.Models.context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {
            
        }

        public DbSet<Station> Stations { get; set; }
    }
}