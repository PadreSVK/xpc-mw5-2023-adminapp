namespace AdminApp.DAL.Entities;

public record CampEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string CampName { get; set; }

    public CurrentYearEntity CurrentYear { get; set; }
    public Guid CurrentYearId { get; set; }

    public ICollection<SessionEntity> Sessions { get; set; } = new List<SessionEntity>();
    public ICollection<AccomodationTypeEntity> AccomodationTypes { get; set;} = new List<AccomodationTypeEntity>();

}

