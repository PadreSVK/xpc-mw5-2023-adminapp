using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class AccomodationEntityMapper : IEntityMapper<AccomodationEntity>
{
    public void MapToExistingEntity(AccomodationEntity existingEntity, AccomodationEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.AccomodationNumber = newEntity.AccomodationNumber;
        existingEntity.Session = newEntity.Session;
        existingEntity.SessionId = newEntity.SessionId;
    }
}

