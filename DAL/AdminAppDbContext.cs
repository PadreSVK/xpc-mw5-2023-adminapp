using AdminApp.DAL.Entities;
using AdminApp.DAL.Seeds;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL;

public class AdminAppDbContext : DbContext
{
    private readonly bool _seedDemoData;

    public AdminAppDbContext(DbContextOptions contextOptions, bool seedDemoData = false) : base(contextOptions) => _seedDemoData = seedDemoData;

    public DbSet<RegistrationEntity> RegistrationEntities => Set<RegistrationEntity>();
    // fix later
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RegistrationEntity>().Property(i => i.EmailAddress).IsRequired();

        if (_seedDemoData)
        {
            RegistrationSeeds.Seed(modelBuilder);
        }
    }
}