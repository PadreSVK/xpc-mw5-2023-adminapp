using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record RegistrationEntity : EntityBase
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string EmailAddress { get; set; }
    public required string PhoneNumber { get; set; }
    public required DepartmentEnum Department { get; set; }
    public required DateTime BirthDate { get; set; }
    public required Gender Gender { get; set; }
    public ICollection<RegistrationEntity>? Roommates { get; set; }
    public required Session Session { get; set; }
    public required TransportMode TransportMode { get; set; }
    public required RegistrationStatus RegistrationStatus { get; set; }
}

