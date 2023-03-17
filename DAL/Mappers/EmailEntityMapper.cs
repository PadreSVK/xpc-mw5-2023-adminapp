using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class EmailEntityMapper : IEntityMapper<EmailEntity>
{
    public void MapToExistingEntity(EmailEntity existingEntity, EmailEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.Email = newEntity.Email;
        existingEntity.RegistrationId = newEntity.RegistrationId;
        existingEntity.Registration = newEntity.Registration;
    }
}
