namespace AdminApp.DAL.Entities;

public record CurrentYearEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string CurrentYear { get; set; }
    public BarInventoryEntity BarInventory { get; set; }

    public ICollection<CampEntity> Camps { get; set; } = new List<CampEntity>();
}

