using Microsoft.EntityFrameworkCore;
using PPServer.Models;

 public class ClubContext : DbContext
{
        public ClubContext(DbContextOptions<ClubContext> options)
            : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; } = null!;
}


