using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class DrinkEntityMapper : IEntityMapper<DrinkEntity>
{
    public void MapToExistingEntity(DrinkEntity existingEntity, DrinkEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.DrinkName = newEntity.DrinkName;
        existingEntity.Price = newEntity.Price;
        existingEntity.DrinkIngredients = newEntity.DrinkIngredients;
        existingEntity.BarInventory = newEntity.BarInventory;
        existingEntity.BarInventoryId = newEntity.BarInventoryId;
    }
}
