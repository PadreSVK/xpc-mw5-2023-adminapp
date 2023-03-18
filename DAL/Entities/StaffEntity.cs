using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record StaffEntity : IEntity
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string EmailAddress { get; set; }
    public required string PhoneNumber { get; set; }
    public required DepartmentEnum Department { get; set; }
    public required DateTime BirthDate { get; set; }
    public required GenderEnum Gender { get; set; }
    public required SchoolEnum School { get; set; }
    public required SessionEnum Session { get; set; }
    
}

