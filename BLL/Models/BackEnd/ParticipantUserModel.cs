using AdminApp.Common.Enums;
using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.ParticipantUserModel
{
    public record ParticipantUserModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public EmailEntity? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public DepartmentEntity? Department { get; set; }
        public Guid? DepartmentId { get; set; }
        public DateTime? BirthDate { get; set; }
        public GenderEnum? Gender { get; set; }
        public TransportModeEnum? TransportMode { get; set; }
        public ICollection<RoomMateEntity> Roommates { get; set; } = new List<RoomMateEntity>();
        public Guid? ParticipantId { get; set; }
        public ParticipantEntity? Participant { get; set; }
        public int? AccomodationNumber { get; set; }
        public ICollection<ParticipantEntity> Participants { get; set; } = new List<ParticipantEntity>();
        public SessionEntity? Session { get; set; }
        public Guid? SessionId { get; set; }
    }

}

