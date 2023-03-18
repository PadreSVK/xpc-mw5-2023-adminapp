namespace AdminApp.DAL.Entities;

public record StaffAccomodationEntity : IEntity
{
    public required Guid Id { get; set; }
    public required int AccomodationNumber { get; set; }

    public ICollection<StaffEntity> Staff { get; set; } = new List<StaffEntity>();

    public SessionEntity Session { get; set; }
    public Guid SessionId { get; set; }
}