namespace AdminApp.DAL.Entities;

public record RoomMateEntity : IEntity
{
    public Guid Id { get; set; }
    public required string RoommateEmail { get; set; }
    public Guid RegistrationId { get; set; }
    public RegistrationEntity Registration { get; set; }
}
