using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace AdminApp.DAL.Seeds;

public static class RegistrationSeeds
{
    
    public static readonly RegistrationEntity Registration1 = new()
    {
        Id = Guid.Parse("798e40a3-f447-4c98-8d6e-410b0db0dc3b"),
        FirstName = "matej",
        LastName = "malysa",
        PhoneNumber = "777334077",
        BirthDate = DateTime.Parse("5/1/2008 8:30:52 AM"),
        DepartmentId = DepartmentSeeds.Department1.Id,
        Gender = Common.Enums.GenderEnum.Male,
        TransportMode = Common.Enums.TransportModeEnum.Bus,
        
        ParticipantId = ParticipantSeeds.Participant1.Id,

    };

    public static readonly RegistrationEntity Registration2 = new()
    {
        Id = Guid.Parse("fac14250-a0b3-4d7b-a6e9-fa7f80a1d2dc"),
        FirstName = "josef",
        LastName = "otevrel",
        PhoneNumber = "879546213",
        BirthDate = DateTime.Parse("5/1/2008 8:30:52 AM"),
        DepartmentId = DepartmentSeeds.Department1.Id,
        Gender = Common.Enums.GenderEnum.Male,
        TransportMode = Common.Enums.TransportModeEnum.Bus,
        
        ParticipantId = ParticipantSeeds.Participant2.Id,
    };

    public static readonly RegistrationEntity Registration3 = new()
    {
        Id = Guid.Parse("5e7da486-ce8a-4306-82e0-ab5dd9596da5"),
        FirstName = "Jakub",
        LastName = "Mahdal",
        PhoneNumber = "757755555",
        BirthDate = DateTime.Parse("5/1/2008 8:30:52 AM"),
        DepartmentId = DepartmentSeeds.Department2.Id,
        Gender = Common.Enums.GenderEnum.Male,
        TransportMode = Common.Enums.TransportModeEnum.Bus,
        
        ParticipantId = ParticipantSeeds.Participant3.Id,
    };
   

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<RegistrationEntity>().HasData(Registration1, Registration2, Registration3);
    
        
    
}
