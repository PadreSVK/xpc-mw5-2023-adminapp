using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class EmailEntityMapper : IEntityMapper<EmailEntity>
{
    public void MapToExistingEntity(EmailEntity existingEntity, EmailEntity newEntity)
    {
        existingEntity.Email = newEntity.Email;
    }
}
