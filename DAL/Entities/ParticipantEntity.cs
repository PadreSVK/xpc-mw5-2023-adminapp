using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record ParticipantEntity : IEntity
{
    public required Guid Id { get; set; }
    public required RegistrationStatusEnum RegistrationStatus { get; set; }

    public RegistrationEntity Registration { get; set; }
    public PersonalInfoEntity PersonalInfo { get; set; }
    public AccomodationEntity Accomodation { get; set; }
    public Guid AccomodationId { get; set; }
    public ICollection<PaymentEntity> Payments { get; set; } = new List<PaymentEntity>();

}

