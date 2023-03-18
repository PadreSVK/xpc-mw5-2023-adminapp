using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record RegistrationEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set;}
    public required string LastName { get; set;}
    public required EmailEntity EmailAddress { get; set; }
    public required string PhoneNumber { get; set; }
    public required DepartmentEntity Department { get; set; }
    public required DateTime BirthDate { get; set; }
    public required GenderEnum Gender { get; set; }
    public required TransportModeEnum TransportMode { get; set; }
    
    public ICollection<RoomMateEntity> Roommates { get; set; } = new List<RoomMateEntity>();
    
    public Guid ParticipantId { get; set; }
    public ParticipantEntity Participant { get; set; }
}

