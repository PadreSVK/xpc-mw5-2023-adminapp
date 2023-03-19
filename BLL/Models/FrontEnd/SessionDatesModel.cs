using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.SessionDatesModel
{
    public record SessionDatesModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public string? FullPrice { get; set; }
        public string? Deposit { get; set; }
        public Guid? Id { get; set; }
        public string? SessionName { get; set; }
        public ICollection<AccomodationEntity> Accomodation { get; set; } = new List<AccomodationEntity>();
        public CampEntity? Camp { get; set; }
        public Guid? CampId { get; set; }

    }
}
