using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record ParticipantEntity : EntityBase
{
    public required RegistrationEntity Registration { get; set; }
    public PaymentEntity? Payment { get; set; } 
    public PersonalInfoEntity? PersonalInfo { get; set; }
}

