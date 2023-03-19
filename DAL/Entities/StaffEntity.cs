using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record StaffEntity : IEntity
{
    public Guid Id { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string EmailAddress { get; set; }
    public required string PhoneNumber { get; set; }
    public required DateTime BirthDate { get; set; }
    public required GenderEnum Gender { get; set; }
    public required string AddressLine1 { get; set; }
    public required string AddressLine2 { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public DepartmentEntity Department { get; set; }
    public Guid DepartmentId { get; set; }
    public StaffAccomodationEntity StaffAccomodation { get; set; } //?
    public Guid StaffAccomodationId { get; set; }
}

