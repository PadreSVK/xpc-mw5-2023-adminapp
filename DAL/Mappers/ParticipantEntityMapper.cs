using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class ParticipantEntityMapper : IEntityMapper<ParticipantEntity>
{
    public void MapToExistingEntity(ParticipantEntity existingEntity, ParticipantEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.RegistrationStatus = newEntity.RegistrationStatus;
        existingEntity.Registration = newEntity.Registration;
        existingEntity.PersonalInfo = newEntity.PersonalInfo;
        existingEntity.Accomodation = newEntity.Accomodation;
        existingEntity.AccomodationId = newEntity.AccomodationId;
        existingEntity.Payments = newEntity.Payments;
    }
}


