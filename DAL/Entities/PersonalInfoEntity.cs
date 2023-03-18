using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record PersonalInfoEntity : IEntity
{
    public Guid Id { get; set; }
    public required string AddressLine1 { get; set; }
    public required string AddressLine2 { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public Guid ParticipantId { get; set; }
    public ParticipantEntity Participant { get; set; }
}

