using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class AccomodationTypeSeeds
{

    public static readonly AccomodationTypeEntity AccomodationType1 = new()
    {
        Id = Guid.NewGuid(),
        Quantity = 8,
        NumberOfPeople = 4,
        CampId = CampSeeds.Camp1.Id,
    };
    public static readonly AccomodationTypeEntity AccomodationType2 = new()
    {
        Id = Guid.NewGuid(),
        Quantity = 5,
        NumberOfPeople = 6,
        CampId = CampSeeds.Camp1.Id,
    };
    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<AccomodationTypeEntity>().HasData(AccomodationType1, AccomodationType2);
}
