using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class BarItemSeeds
{

    public static readonly BarItemEntity BarItem1 = new()
    {
        Id = Guid.NewGuid(),
        BarItemName = "Vodka",
        Quantity = 1,
        QuantitySize = 1,
        Unit = 1,
        UnitPrice = 1,
        InStock = 1,
        BarInventoryId = BarInventorySeeds.BarInventory1.Id,
        DrinkIngredientId = DrinkIngredientSeeds.DrinkIngredient1.Id,
    };
    public static readonly BarItemEntity BarItem2 = new()
    {
        Id = Guid.NewGuid(),
        BarItemName = "Rum",
        Quantity = 1,
        QuantitySize = 1,
        Unit = 1,
        UnitPrice = 1,
        InStock = 1,
        BarInventoryId = BarInventorySeeds.BarInventory1.Id,
        DrinkIngredientId = DrinkIngredientSeeds.DrinkIngredient2.Id,
    };
    public static readonly BarItemEntity BarItem3 = new()
    {
        Id = Guid.NewGuid(),
        BarItemName = "Jegr",
        Quantity = 1,
        QuantitySize = 1,
        Unit = 1,
        UnitPrice = 1,
        InStock = 1,
        BarInventoryId = BarInventorySeeds.BarInventory1.Id,
        DrinkIngredientId = DrinkIngredientSeeds.DrinkIngredient3.Id,
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<BarItemEntity>().HasData(BarItem1, BarItem2, BarItem3);

}
