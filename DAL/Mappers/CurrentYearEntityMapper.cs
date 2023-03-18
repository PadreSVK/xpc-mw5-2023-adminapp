using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class CurrentYearEntityMapper : IEntityMapper<CurrentYearEntity>
{
    public void MapToExistingEntity(CurrentYearEntity existingEntity, CurrentYearEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.CurrentYear = newEntity.CurrentYear;
        existingEntity.BarInventory = newEntity.BarInventory;
        existingEntity.Camps = newEntity.Camps;
    }
}
