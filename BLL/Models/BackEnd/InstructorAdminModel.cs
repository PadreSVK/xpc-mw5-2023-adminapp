using AdminApp.Common.Enums;
using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.InstructorAdminModel
{
    public record InstructorAdminModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Enum? Gender { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public DepartmentEntity? Department { get; set; }
        public Guid? DepartmentId { get; set; }
        public StaffAccomodationEntity? StaffAccomodation { get; set; } //?
        public Guid? StaffAccomodationId { get; set; }
    }
}
