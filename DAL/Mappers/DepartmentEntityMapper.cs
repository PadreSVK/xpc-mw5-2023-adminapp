using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class DepartmentEntityMapper : IEntityMapper<DepartmentEntity>
{
    public void MapToExistingEntity(DepartmentEntity existingEntity, DepartmentEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.DepartmentName = newEntity.DepartmentName;
        existingEntity.DepartmentNumber = newEntity.DepartmentNumber;
        existingEntity.School = newEntity.School;
        existingEntity.SchoolId = newEntity.SchoolId; 
        existingEntity.Registrations = newEntity.Registrations;
        existingEntity.Staff = newEntity.Staff; 
    }
}
