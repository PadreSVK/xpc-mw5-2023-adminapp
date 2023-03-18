using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class StaffEntityMapper : IEntityMapper<StaffEntity>
{
    public void MapToExistingEntity(StaffEntity existingEntity, StaffEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.FirstName = newEntity.FirstName;
        existingEntity.LastName = newEntity.LastName; 
        existingEntity.EmailAddress = newEntity.EmailAddress;
        existingEntity.PhoneNumber = newEntity.PhoneNumber; 
        existingEntity.Department = newEntity.Department;
        existingEntity.BirthDate = newEntity.BirthDate;
        existingEntity.Gender = newEntity.Gender;
        existingEntity.AddressLine1 = newEntity.AddressLine1;
        existingEntity.AddressLine2 = newEntity.AddressLine2;
        existingEntity.City = newEntity.City;
        existingEntity.PostalCode = newEntity.PostalCode;
        existingEntity.Country = newEntity.Country;
        existingEntity.StaffAccomodation = newEntity.StaffAccomodation;
        existingEntity.StaffAccomodationId = newEntity.StaffAccomodationId;
    }
}
