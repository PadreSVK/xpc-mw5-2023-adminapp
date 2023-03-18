
namespace AdminApp.DAL.Entities;

public class DepartmentEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string DepartmentName { get; set; }
    public required string DepartmentId { get; set; }
    public SchoolEntity School { get; set; }
    public Guid SchoolId { get; set; }
}
