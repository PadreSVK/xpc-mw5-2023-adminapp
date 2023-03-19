using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.CurrentYearModel
{
    public record CurrentYearModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? CurrentYear { get; set; }
        public BarInventoryEntity? BarInventory { get; set; }
        public ICollection<CampEntity> Camps { get; set; } = new List<CampEntity>();
    }
}
