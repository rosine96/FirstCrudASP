using Microsoft.EntityFrameworkCore;

namespace Watchlist.Models
    
{
    public class MvcWatchlistContext: DbContext
    {
        public MvcWatchlistContext(DbContextOptions<MvcWatchlistContext>options)
            : base(options)
        { 
        }
        public DbSet<Films>? Films { get; set; }
        public DbSet<Users>? Users { get; set; }
    }
}
