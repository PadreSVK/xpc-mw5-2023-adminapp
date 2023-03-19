using AdminApp.DAL.Entities;
using AdminApp.DAL.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Net;

namespace AdminApp.DAL;

public class AdminAppDbContext : DbContext
{
    private readonly bool _seedDemoData;

    public AdminAppDbContext(DbContextOptions contextOptions, bool seedDemoData = true) : base(contextOptions) => _seedDemoData = seedDemoData;
    public DbSet<AccomodationEntity> AccomodationEntities => Set<AccomodationEntity>();
    public DbSet<AccomodationTypeEntity> AccomodationTypeEntities => Set<AccomodationTypeEntity>();
    public DbSet<BarInventoryEntity> BarInventoryEntities => Set<BarInventoryEntity>();
    public DbSet<BarItemEntity> BarItemEntities => Set<BarItemEntity>();
    public DbSet<CampEntity> CampEntities => Set<CampEntity>();
    public DbSet<CurrentYearEntity> CurrentYearEntities => Set<CurrentYearEntity>();
    public DbSet<DepartmentEntity> DepartmentEntities => Set<DepartmentEntity>();
    public DbSet<DrinkEntity> DrinkEntities => Set<DrinkEntity>();
    public DbSet<DrinkIngredientEntity> DrinkIngredientEntities => Set<DrinkIngredientEntity>();
    public DbSet<EmailEntity> EmailEntities => Set<EmailEntity>();
    public DbSet<ParticipantEntity> ParticipantEntities => Set<ParticipantEntity>();
    public DbSet<PaymentEntity> PaymentEntities => Set<PaymentEntity>();
    public DbSet<PersonalInfoEntity> PersonalInfoEntities => Set<PersonalInfoEntity>();
    public DbSet<RegistrationEntity> RegistrationEntities => Set<RegistrationEntity>();
    public DbSet<RoomMateEntity> RoomMateEntities => Set<RoomMateEntity>();
    public DbSet<SchoolEntity> SchoolEntities => Set<SchoolEntity>();
    public DbSet<SessionEntity> SessionEntities => Set<SessionEntity>();
    public DbSet<StaffEntity> StaffEntities => Set<StaffEntity>();


    // fix later
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CampEntity>()
            .HasOne(a => a.CurrentYear)
            .WithMany(b => b.Camps)
            .HasForeignKey(b => b.CurrentYearId);

        modelBuilder.Entity<CurrentYearEntity>()
            .HasOne(a => a.BarInventory)
            .WithOne(b => b.CurrentYear)
            .HasForeignKey<BarInventoryEntity>(b => b.CurrentYearId);

        modelBuilder.Entity<BarItemEntity>()
            .HasOne(a => a.BarInventory)
            .WithMany(b => b.BarItems)
            .HasForeignKey(b => b.BarInventoryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<DrinkEntity>()
            .HasOne(a => a.BarInventory)
            .WithMany(b => b.Drinks)
            .HasForeignKey(b => b.BarInventoryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<DrinkIngredientEntity>()
            .HasOne(a => a.Drink)
            .WithMany(b => b.DrinkIngredients)
            .HasForeignKey(b => b.DrinkId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<DrinkIngredientEntity>()
            .HasOne(a => a.BarItem)
            .WithOne(b => b.DrinkIngredient)
            .HasForeignKey<BarItemEntity>(b => b.DrinkIngredientId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SessionEntity>()
            .HasOne(a => a.Camp)
            .WithMany(b => b.Sessions)
            .HasForeignKey(b => b.CampId);

        modelBuilder.Entity<AccomodationTypeEntity>()
            .HasOne(a => a.Camp)
            .WithMany(b => b.AccomodationTypes)
            .HasForeignKey(b => b.CampId);

        modelBuilder.Entity<AccomodationEntity>()
            .HasOne(a => a.Session)
            .WithMany(b => b.Accomodation)
            .HasForeignKey(b => b.SessionId);

        modelBuilder.Entity<ParticipantEntity>()
            .HasOne(a => a.Accomodation)
            .WithMany(b => b.Participants)
            .HasForeignKey(b => b.AccomodationId);

        modelBuilder.Entity<ParticipantEntity>()
            .HasOne(a => a.Registration)
            .WithOne(b => b.Participant)
            .HasForeignKey<RegistrationEntity>(b => b.ParticipantId);

        modelBuilder.Entity<ParticipantEntity>()
            .HasOne(a => a.PersonalInfo)
            .WithOne(b => b.Participant)
            .HasForeignKey<PersonalInfoEntity>(b => b.ParticipantId);

        modelBuilder.Entity<PaymentEntity>()
            .HasOne(a => a.Participant)
            .WithMany(b => b.Payments)
            .HasForeignKey(b => b.ParticipantId);

        modelBuilder.Entity<RegistrationEntity>()
            .HasOne(a => a.EmailAddress)
            .WithOne(b => b.Registration)
            .HasForeignKey<EmailEntity>(b => b.RegistrationId);

        modelBuilder.Entity<RoomMateEntity>()
            .HasOne(a => a.Registration)
            .WithMany(b => b.Roommates)
            .HasForeignKey(b => b.RegistrationId);


        if (_seedDemoData)
        {

            SchoolSeeds.Seed(modelBuilder);
            DepartmentSeeds.Seed(modelBuilder);
            CurrentYearSeeds.Seed(modelBuilder);
            CampSeeds.Seed(modelBuilder);
            AccomodationTypeSeeds.Seed(modelBuilder);
            SessionSeeds.Seed(modelBuilder);
            AccomodationSeeds.Seed(modelBuilder);
            StaffAccomodationSeeds.Seed(modelBuilder);
            StaffSeeds.Seed(modelBuilder);
            ParticipantSeeds.Seed(modelBuilder);
            RegistrationSeeds.Seed(modelBuilder);
            PersonalInfoSeeds.Seed(modelBuilder);
            RoomMateSeeds.Seed(modelBuilder);
            PaymentSeeds.Seed(modelBuilder);
            BarInventorySeeds.Seed(modelBuilder);
            DrinkSeeds.Seed(modelBuilder);
            DrinkIngredientSeeds.Seed(modelBuilder);
            BarItemSeeds.Seed(modelBuilder);
            EmailSeeds.Seed(modelBuilder);
        }
    }
}