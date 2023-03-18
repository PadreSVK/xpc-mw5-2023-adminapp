using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class CampEntityMapper : IEntityMapper<CampEntity>
{
    public void MapToExistingEntity(CampEntity existingEntity, CampEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.CampName = newEntity.CampName;
        existingEntity.CurrentYear = newEntity.CurrentYear;
        existingEntity.CurrentYearId = newEntity.CurrentYearId;
        existingEntity.Sessions = newEntity.Sessions;
        existingEntity.AccomodationTypes = newEntity.AccomodationTypes;
    }
}

