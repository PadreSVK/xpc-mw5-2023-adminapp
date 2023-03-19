using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class CampSeeds
{

    public static readonly CampEntity Camp1 = new()
    {
        Id = Guid.Parse("111bb548-dfc3-429d-802e-6605b2f9eaf7"),
        CampName = "Vranov",
        CurrentYearId = CurrentYearSeeds.Year.Id,

        

    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<CampEntity>().HasData(Camp1);



}
