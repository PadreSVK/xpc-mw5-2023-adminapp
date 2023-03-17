namespace AdminApp.DAL.Entities;

public record EmailEntity : EntityBase
{
    public required string Email { get; set; }
}
