using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class SchoolEntityMapper : IEntityMapper<SchoolEntity>
{
    public void MapToExistingEntity(SchoolEntity existingEntity, SchoolEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.SchoolId = newEntity.SchoolId;
        existingEntity.SchoolName = newEntity.SchoolName;
        existingEntity.Departments = newEntity.Departments;
    }
}
