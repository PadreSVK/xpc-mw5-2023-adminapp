using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record AccomodationEntity : EntityBase
{
    public required int AccomodationNumber { get; set; }
    public ICollection<ParticipantEntity>? Participants { get; set; }
}

