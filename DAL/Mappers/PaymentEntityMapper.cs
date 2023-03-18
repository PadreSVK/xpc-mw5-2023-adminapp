using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class PaymentEntityMapper : IEntityMapper<PaymentEntity>
{
    public void MapToExistingEntity(PaymentEntity existingEntity, PaymentEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.Amount = newEntity.Amount;
        existingEntity.ParticipantId = newEntity.ParticipantId;
        existingEntity.Participant = newEntity.Participant;
    }
}
