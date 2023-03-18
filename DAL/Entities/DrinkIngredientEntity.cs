namespace AdminApp.DAL.Entities;

public record DrinkIngredientEntity: IEntity
{
    public required Guid Id { get; set; }
    public required BarItemEntity BarItem { get; set; }
    public required int NumberOfUnits { get; set; }

    public DrinkEntity Drink { get; set; }
    public Guid DrinkId { get; set; }
    

}
