namespace AdminApp.DAL.Entities;

public record BarItemEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string BarItemName { get; set; }
    public required int Quantity { get; set; }
    public required double QuantitySize { get; set; }
    public required double Unit { get;set; }
    public required int UnitPrice { get; set; }
    public required double InStock { get; set;}

    public BarInventoryEntity BarInventory { get; set; }
    public Guid BarInventoryId { get; set; }
    public DrinkIngredientEntity DrinkIngredient { get; set; }
    public Guid DrinkIngredientId { get; set; }

}
