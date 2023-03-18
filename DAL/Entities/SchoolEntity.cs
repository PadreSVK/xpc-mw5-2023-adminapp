namespace AdminApp.DAL.Entities;

public record SchoolEntity : IEntity
{
    
    public required Guid Id { get; set; }
    public required int SchoolId { get; set; }
    public required string SchoolName { get; set; }
    public ICollection<DepartmentEntity> Departments { get; set; } = new List<DepartmentEntity>();

}
