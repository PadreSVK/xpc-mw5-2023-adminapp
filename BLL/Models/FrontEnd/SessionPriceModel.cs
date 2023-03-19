using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.SessionPriceModel
{
    public record SessionPriceModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? CampName { get; set; }

        public CurrentYearEntity? CurrentYear { get; set; }
        public Guid? CurrentYearId { get; set; }

        public ICollection<SessionEntity> Sessions { get; set; } = new List<SessionEntity>();
        public ICollection<AccomodationTypeEntity> AccomodationTypes { get; set; } = new List<AccomodationTypeEntity>();
    }
}
