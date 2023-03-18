using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class BarInventoryEntityMapper : IEntityMapper<BarInventoryEntity>
{
    public void MapToExistingEntity(BarInventoryEntity existingEntity, BarInventoryEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.TotalBalance = newEntity.TotalBalance;
        existingEntity.BarItems = newEntity.BarItems;
        existingEntity.Drinks = newEntity.Drinks;
        existingEntity.CurrentYear = newEntity.CurrentYear;
        existingEntity.CurrentYearId = newEntity.CurrentYearId;
    }
}
