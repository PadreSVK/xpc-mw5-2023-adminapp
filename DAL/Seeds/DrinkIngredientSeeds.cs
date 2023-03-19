using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class DrinkIngredientSeeds
{

    public static readonly DrinkIngredientEntity DrinkIngredient1 = new()
    {
        Id = Guid.NewGuid(),
        NumberOfUnits = 1,
        DrinkId = DrinkSeeds.Drink1.Id,

    };
    public static readonly DrinkIngredientEntity DrinkIngredient2 = new()
    {
        Id = Guid.NewGuid(),
        NumberOfUnits = 1,
        DrinkId = DrinkSeeds.Drink2.Id,
        
    }; 
    public static readonly DrinkIngredientEntity DrinkIngredient3 = new()
    {
        Id = Guid.NewGuid(),
        NumberOfUnits = 2,
        DrinkId = DrinkSeeds.Drink3.Id,
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<DrinkIngredientEntity>().HasData(DrinkIngredient1, DrinkIngredient2, DrinkIngredient3);

}
