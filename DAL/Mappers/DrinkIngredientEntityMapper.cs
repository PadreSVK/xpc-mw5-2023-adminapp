using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class DrinkIngredientEntityMapper : IEntityMapper<DrinkIngredientEntity>
{
    public void MapToExistingEntity(DrinkIngredientEntity existingEntity, DrinkIngredientEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.BarItem = newEntity.BarItem;
        existingEntity.NumberOfUnits = newEntity.NumberOfUnits;
        
        existingEntity.Drink = newEntity.Drink;
        existingEntity.DrinkId = newEntity.DrinkId;
    }
}
