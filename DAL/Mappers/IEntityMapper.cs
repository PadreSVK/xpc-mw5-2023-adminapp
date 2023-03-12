using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public interface IEntityMapper<in TEntity> where TEntity : IEntity
{
    void MapToExistingEntity(TEntity existingEntity, TEntity newEntity);
}
