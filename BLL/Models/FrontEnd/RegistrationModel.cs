using AdminApp.DAL.Entities;
using AdminApp.Common.Enums;

namespace AdminApp.BLL.Models.RegistrationModel
{
    public record RegistrationModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public EmailEntity? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public DepartmentEntity? Department { get; set; }
        public Guid? DepartmentId { get; set; }
        public DateTime? BirthDate { get; set; }
        public ICollection<RoomMateEntity> Roommates { get; set; } = new List<RoomMateEntity>();
        public GenderEnum? Gender { get; set; }
        public TransportModeEnum? TransportMode { get; set; }
        public Guid? ParticipantId { get; set; }
        public ParticipantEntity? Participant { get; set; }

    }
}
