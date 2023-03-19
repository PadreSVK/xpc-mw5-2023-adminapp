namespace AdminApp.DAL.Entities;

public record PaymentEntity : IEntity
{
    public required Guid Id { get; set; }
    public required int Amount { get; set; }

    public Guid ParticipantId { get; set; }
    public ParticipantEntity? Participant { get; set; }
}

