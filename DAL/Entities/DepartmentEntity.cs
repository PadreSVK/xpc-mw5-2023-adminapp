namespace AdminApp.DAL.Entities;

public class DepartmentEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string DepartmentName { get; set; }
    public required int DepartmentNumber { get; set; }
    public ICollection<RegistrationEntity> Registrations { get; set; } = new List<RegistrationEntity>();

    public ICollection<StaffEntity> Staff { get; set; } = new List<StaffEntity>();
    public SchoolEntity School { get; set; }
    public Guid SchoolId { get; set; }
}
