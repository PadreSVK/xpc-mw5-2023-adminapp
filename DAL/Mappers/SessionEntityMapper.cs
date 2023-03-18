using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class SessionEntityMapper : IEntityMapper<SessionEntity>
{
    public void MapToExistingEntity(SessionEntity existingEntity, SessionEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.SessionName = newEntity.SessionName;
        existingEntity.Accomodation =   newEntity.Accomodation;
        existingEntity.Camp = newEntity.Camp;
        existingEntity.CampId = newEntity.CampId;
    }
}
