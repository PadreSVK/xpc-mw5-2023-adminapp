using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class BarInventorySeeds
{

    public static readonly BarInventoryEntity BarInventory1 = new()
    {
        Id = Guid.NewGuid(),
        TotalBalance = 1258.8,
        CurrentYearId = CurrentYearSeeds.Year.Id

    };
        
    

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<BarInventoryEntity>().HasData(BarInventory1);

}
