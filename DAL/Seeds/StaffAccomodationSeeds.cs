using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class StaffAccomodationSeeds
{

    public static readonly StaffAccomodationEntity StaffAccomodation1 = new()
    {
        Id = Guid.NewGuid(),
        AccomodationNumber = 1,
        SessionId = SessionSeeds.Session1.Id,
    };
    public static readonly StaffAccomodationEntity StaffAccomodation2 = new()
    {
        Id = Guid.NewGuid(),
        AccomodationNumber = 2,
        SessionId = SessionSeeds.Session1.Id,
    };
    public static readonly StaffAccomodationEntity StaffAccomodation3 = new()
    {
        Id = Guid.NewGuid(),
        AccomodationNumber = 3,
        SessionId = SessionSeeds.Session1.Id,
    };

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<StaffAccomodationEntity>().HasData(StaffAccomodation1, StaffAccomodation2, StaffAccomodation3);

}
