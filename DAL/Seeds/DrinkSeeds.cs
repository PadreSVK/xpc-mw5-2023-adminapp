using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class DrinkSeeds
{

    public static readonly DrinkEntity Drink1 = new()
    {
        Id = Guid.NewGuid(),
        DrinkName = "Cubalibre",
        Price = 80,
        BarInventoryId = BarInventorySeeds.BarInventory1.Id,
    };
    public static readonly DrinkEntity Drink2 = new()
    {
        Id = Guid.NewGuid(),
        DrinkName = "Mojito",
        Price = 75,
        BarInventoryId = BarInventorySeeds.BarInventory1.Id,
    };
    public static readonly DrinkEntity Drink3 = new()
    {
        Id = Guid.NewGuid(),
        DrinkName = "GinTOnic",
        Price = 100,
        BarInventoryId = BarInventorySeeds.BarInventory1.Id,
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<DrinkEntity>().HasData(Drink1, Drink2, Drink3);

}