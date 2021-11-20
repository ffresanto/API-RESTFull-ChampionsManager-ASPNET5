using Microsoft.EntityFrameworkCore;

namespace API_Champions_Manager.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Award> Awards { get; set; }
    }
}
