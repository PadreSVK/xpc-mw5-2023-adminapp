﻿using AdminApp.DAL.Entities;

namespace AdminApp.DAL.Mappers;

public class RegistrationEntityMapper : IEntityMapper<RegistrationEntity>
{
    public void MapToExistingEntity(RegistrationEntity existingEntity, RegistrationEntity newEntity)
    {
        existingEntity.Id = newEntity.Id;
        existingEntity.FirstName = newEntity.FirstName;
        existingEntity.LastName = newEntity.LastName;
        existingEntity.EmailAddress = newEntity.EmailAddress;
        existingEntity.PhoneNumber = newEntity.PhoneNumber;
        existingEntity.Department = newEntity.Department;
        existingEntity.BirthDate = newEntity.BirthDate;
        existingEntity.Gender = newEntity.Gender;
        existingEntity.TransportMode = newEntity.TransportMode;
        existingEntity.Roommates = newEntity.Roommates;
        existingEntity.ParticipantId = newEntity.ParticipantId;
        existingEntity.Participant = newEntity.Participant;
    }
}
