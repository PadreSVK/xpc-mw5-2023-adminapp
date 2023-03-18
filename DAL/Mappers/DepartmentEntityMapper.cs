using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class DepartmentEntityMapper : IEntityMapper<DepartmentEntity>
{
    public void MapToExistingEntity(DepartmentEntity existingEntity, DepartmentEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.DepartmentName = newEntity.DepartmentName;
        existingEntity.DepartmentId = newEntity.DepartmentId;
        existingEntity.School = newEntity.School;
        existingEntity.SchoolId = newEntity.SchoolId; 
    }
}
