using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class PersonalInfoEntityMapper : IEntityMapper<PersonalInfoEntity>
{
    public void MapToExistingEntity(PersonalInfoEntity existingEntity, PersonalInfoEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.AddressLine1 = newEntity.AddressLine1;
        existingEntity.AddressLine2 = newEntity.AddressLine2;
        existingEntity.City = newEntity.City;
        existingEntity.Country = newEntity.Country;
        existingEntity.ParticipantId = newEntity.ParticipantId;
        existingEntity.Participant = newEntity.Participant;
    }
}

