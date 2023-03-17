namespace AdminApp.DAL.Entities;

public record EmailEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string Email { get; set; }
    public required Guid RegistrationId { get; set; }
    public RegistrationEntity Registration { get; set; }
}
