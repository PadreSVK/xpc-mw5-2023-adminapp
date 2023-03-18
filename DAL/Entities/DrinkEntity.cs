namespace AdminApp.DAL.Entities;

public record DrinkEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string DrinkName { get; set; }
    public required int Price { get; set; }
    public ICollection<DrinkIngredientEntity> DrinkIngredients { get; set;}

    public BarInventoryEntity BarInventory { get; set; }
    public Guid BarInventoryId { get; set; }
}
