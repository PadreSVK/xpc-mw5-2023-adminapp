using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class StaffAcomodationEntityMaper : IEntityMapper<StaffAccomodationEntity>
{
    public void MapToExistingEntity(StaffAccomodationEntity existingEntity, StaffAccomodationEntity newEntity)
    {
       existingEntity.Id = newEntity.Id;
        existingEntity.AccomodationNumber = newEntity.AccomodationNumber; 
        existingEntity.Staff = newEntity.Staff;
        existingEntity.Session = newEntity.Session;
        existingEntity.SessionId = newEntity.SessionId;
    }
}
