namespace AdminApp.DAL.Entities;

public record SessionEntity : IEntity
{
    public required Guid Id { get; set; }
    public string SessionName { get; set; }

    public ICollection<AccomodationEntity> Accomodation { get; set;} = new List<AccomodationEntity>();

    public CampEntity Camp { get; set; }
    public Guid CampId { get; set; }

}

