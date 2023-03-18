namespace AdminApp.DAL.Entities;

public record BarInventoryEntity : IEntity
{
    public required Guid Id {get; set;}
    public required double TotalBalance { get; set;}

    public ICollection<BarItemEntity> BarItems { get; set; } = new List<BarItemEntity>();
    public ICollection<DrinkEntity> Drinks { get; set; } = new List<DrinkEntity>();

    public CurrentYearEntity CurrentYear { get; set; }
    public Guid CurrentYearId { get; set; }
}

