using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class AccomodationTypeEntityMapper : IEntityMapper<AccomodationTypeEntity>
{
    public void MapToExistingEntity(AccomodationTypeEntity existingEntity, AccomodationTypeEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.Quantity = newEntity.Quantity;
        existingEntity.NumberOfPeople = newEntity.NumberOfPeople;
        existingEntity.Camp = newEntity.Camp;
        existingEntity.CampId = newEntity.CampId;
    }
}
