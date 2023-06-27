using Microsoft.EntityFrameworkCore;

namespace DAL.DbModels;

public class DefaultDbContext : DbContext
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Hero> Heroes { get; set; }
    public virtual DbSet<Ability> Abilities { get; set; }
    
}