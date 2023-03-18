namespace AdminApp.DAL.Entities;

public record AccomodationTypeEntity : IEntity
{
    public required Guid Id { get; set; }
    public required int Quantity { get; set; }
    public required int NumberOfPeople { get; set; }

    public CampEntity Camp { get; set; }
    public Guid CampId { get; set; }

}


