using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class BarItemEntityMapper : IEntityMapper<BarItemEntity>
{
    public void MapToExistingEntity(BarItemEntity existingEntity, BarItemEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.BarItemName = newEntity.BarItemName; 
        existingEntity.Quantity = newEntity.Quantity;
        existingEntity.QuantitySize = newEntity.QuantitySize;
        existingEntity.Unit = newEntity.Unit;
        existingEntity.UnitPrice = newEntity.UnitPrice;
        existingEntity.InStock = newEntity.InStock;
        existingEntity.BarInventory = newEntity.BarInventory;
        existingEntity.BarInventoryId = newEntity.BarInventoryId;

    }
}
