using Microsoft.EntityFrameworkCore;

namespace Asp_Rauleac_Robert_Rp.Models
{
    public class Asp_Rauleac_Robert_RpContext : DbContext
    {
        public Asp_Rauleac_Robert_RpContext(DbContextOptions<Asp_Rauleac_Robert_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Rauleac_Robert_Rp.Models.Movie> Movie { get; set; }
    }
}