using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class LoreContext : DbContext
    {
        public LoreContext (DbContextOptions<LoreContext> options)
            : base(options)
        {   
        }

        public DbSet<Lore> HeroLore {get; set;} = default!;
        public DbSet<InGame> Playing {get; set;} = default!;
    }
}