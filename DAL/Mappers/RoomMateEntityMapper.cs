using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class RoomMateEntityMapper : IEntityMapper<RoomMateEntity>
{
    public void MapToExistingEntity(RoomMateEntity existingEntity, RoomMateEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.RoommateEmail = newEntity.RoommateEmail;
        existingEntity.RegistrationId = newEntity.RegistrationId;
        existingEntity.Registration = newEntity.Registration;
    }
}
