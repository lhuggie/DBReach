using Microsoft.EntityFrameworkCore;


namespace DBReach.Models
{
    public class ValueItemContext : DbContext
    {
        public ValueItemContext(DbContextOptions<ValueItemContext> options)
            : base(options)
        {
        }

        public DbSet<ValueItem> ValueItems { get; set; }
    }
}
