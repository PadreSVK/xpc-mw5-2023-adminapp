namespace AdminApp.DAL.Entities;

public record AccomodationEntity : IEntity
{
    public Guid Id { get; set; }
    public required int AccomodationNumber { get; set; }
    public ICollection<ParticipantEntity> Participants { get; set; } = new List<ParticipantEntity>();
    public SessionEntity Session { get; set; }
    public Guid SessionId { get; set; }
}

