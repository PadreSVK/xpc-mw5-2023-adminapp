using AdminApp.DAL.Entities;
using AdminApp.DAL.Seeds;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL;

public class AdminAppDbContext : DbContext
{
    private readonly bool _seedDemoData;

    public AdminAppDbContext(DbContextOptions contextOptions, bool seedDemoData = true) : base(contextOptions) => _seedDemoData = seedDemoData;

    public DbSet<RegistrationEntity> RegistrationEntities => Set<RegistrationEntity>();
    // fix later
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RegistrationEntity>()
            .HasOne(a => a.EmailAddress)
            .WithOne(b => b.Registration);
            //.HasForeignKey<EmailEntity>(b => b.RegistrationId);

        if (_seedDemoData)
        {

            EmailSeeds.Seed(modelBuilder);
            RegistrationSeeds.Seed(modelBuilder);
            
        }
    }
}