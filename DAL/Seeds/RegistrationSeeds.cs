using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class RegistrationSeeds
{
    /*
    public static readonly RegistrationEntity ExampleRegistration = new()
    {
        
        Id = Guid.Parse("db68702a-764b-43b8-8b9b-af213d69d15b"),
        FirstName = "matej",
        LastName = "malysa",
        PhoneNumber = "777334077",
        //Department = Common.Enums.DepartmentEnum.MathematicsSLU,
        BirthDate = DateTime.Parse("5/1/2008 8:30:52 AM"),
        Gender = Common.Enums.GenderEnum.Male,
        //School = Common.Enums.SchoolEnum.VSPJ,
        //Session = Common.Enums.SessionEnum.FirstVSPJ,
        TransportMode = Common.Enums.TransportModeEnum.Bus
        
        Id = Guid.Parse("db68702a-765b-43b8-8b9b-af213d69d15b"),
        FirstName = "Matej",
        LastName = "Malysa",
        //EmailEntity = EmailSeeds.SomeEmail,
        PhoneNumber = "777334077",
        Department = Common.Enums.DepartmentEnum.MathematicsSLU,
        BirthDate = DateTime.Parse("2/16/2008 12:15:12 PM"),
        Gender = Common.Enums.GenderEnum.Male,
        School = Common.Enums.SchoolEnum.VSPJ,
        Session = Common.Enums.SessionEnum.FirstVSPJ,
        TransportMode = Common.Enums.TransportModeEnum.Bus
        

    };
    
    public static readonly RegistrationEntity AnotherRegistration = new()
    {
        
        Id = Guid.Parse("8b3dc969-fa97-4eee-b0c1-e62f52d25ebe"),
        FirstName = "josef",
        LastName = "otevrel",
        PhoneNumber = "123456789",
        //Department = Common.Enums.DepartmentEnum.MathematicsVSPJ,
        BirthDate = DateTime.Parse("2/16/2008 12:15:12 PM"),
        Gender = Common.Enums.GenderEnum.Male,
        //School = Common.Enums.SchoolEnum.SLU,
       // Session = Common.Enums.SessionEnum.FirstSLU,
        TransportMode = Common.Enums.TransportModeEnum.Individual
        
        Id = Guid.Parse("db68702a-764b-43b8-8b9b-af213d69d15b"),
        FirstName = "x",
        LastName = "x",
        EmailEntity = EmailSeeds.SomeOtherEmail,
        PhoneNumber = "x",
        Department = Common.Enums.DepartmentEnum.EconomicStudiesVSPJ,
        BirthDate = DateTime.Parse("5/1/2008 8:30:52 AM"),
        Gender = Common.Enums.GenderEnum.Male,
        School = Common.Enums.SchoolEnum.VSPJ,
        Session = Common.Enums.SessionEnum.FirstVSPJ,
        TransportMode = Common.Enums.TransportModeEnum.Individual
        
    };
*/
    static RegistrationSeeds()
    {
        /*
        ExampleRegistration.Roommates.Add(EmailSeeds.SomeOtherEmail);
        ExampleRegistration.Roommates.Add(EmailSeeds.SomeEmail);
        */
    }
/*
    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<RegistrationEntity>().HasData(ExampleRegistration, AnotherRegistration);
*/
}
