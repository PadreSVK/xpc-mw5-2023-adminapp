using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.SchoolModel
{
    public record SchoolModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? CampName { get; set; }
        public CurrentYearEntity? CurrentYear { get; set; }
        public Guid? CurrentYearId { get; set; }
        public ICollection<SessionEntity> Sessions { get; set; } = new List<SessionEntity>();
        public ICollection<AccomodationTypeEntity> AccomodationTypes { get; set; } = new List<AccomodationTypeEntity>();
        public string? SessionName { get; set; }
        public ICollection<AccomodationEntity> Accomodation { get; set; } = new List<AccomodationEntity>();
        public CampEntity? Camp { get; set; }
        public Guid? CampId { get; set; }
        public int? SchoolNumber { get; set; }
        public string? SchoolName { get; set; }
        public ICollection<DepartmentEntity> Departments { get; set; } = new List<DepartmentEntity>();
        public string? DepartmentName { get; set; }
        public int? DepartmentNumber { get; set; }
        public ICollection<RegistrationEntity> Registrations { get; set; } = new List<RegistrationEntity>();
        public ICollection<StaffEntity> Staff { get; set; } = new List<StaffEntity>();
        public SchoolEntity? School { get; set; }
        public Guid? SchoolId { get; set; }
        public int? AccomodationNumber { get; set; }
        public ICollection<ParticipantEntity> Participants { get; set; } = new List<ParticipantEntity>();
        public SessionEntity? Session { get; set; }
        public Guid? SessionId { get; set; }
    }
}
