using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.InstructorUserModel
{
    public record InstructorUSerModelClass(string Route, Type ViewType, Type ViewModelType)
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public  Guid? Id { get; set; }
        public  string? DepartmentName { get; set; }
        public  int? DepartmentNumber { get; set; }
        public ICollection<RegistrationEntity> Registrations { get; set; } = new List<RegistrationEntity>();
        public ICollection<StaffEntity> Staff { get; set; } = new List<StaffEntity>();
        public SchoolEntity? School { get; set; }
        public Guid? SchoolId { get; set; }
    }
}
