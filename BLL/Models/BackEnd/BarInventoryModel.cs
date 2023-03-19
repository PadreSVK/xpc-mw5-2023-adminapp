using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.BarInventoryModel
{
    public record BarInventoryModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? BarItemName { get; set; }
        public int? Quantity { get; set; }
        public double? QuantitySize { get; set; }
        public double? Unit { get; set; }
        public int? UnitPrice { get; set; }
        public double? InStock { get; set; }
        public DrinkIngredientEntity? DrinkIngredient { get; set; }
        public Guid? DrinkIngredientId { get; set; }
        public BarInventoryEntity? BarInventory { get; set; }
        public Guid? BarInventoryId { get; set; }

    }
}
