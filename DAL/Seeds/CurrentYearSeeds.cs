using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class CurrentYearSeeds
{

    public static readonly CurrentYearEntity Year = new()
    {
        Id = Guid.Parse("1118b548-dfc3-429d-802e-6605b2f9eaf7"),
        CurrentYear = "2023",
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<CurrentYearEntity>().HasData(Year);



}