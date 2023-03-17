using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class RegistrationSeeds
{
    public static readonly RegistrationEntity ExampleRegistration = new()
    {
        Id = Guid.Parse("db68702a-765b-43b8-8b9b-af213d69d15b"),
        FirstName = "Matej",
        LastName = "Malysa",
        EmailAddress = "malysa.matej@gmail.com",
        PhoneNumber = "777334077",
        Department = Common.Enums.DepartmentEnum.MathematicsSLU,
        BirthDate = DateTime.Parse("2/16/2008 12:15:12 PM"),
        Gender = Common.Enums.GenderEnum.Male,
        School = Common.Enums.SchoolEnum.VSPJ,
        Session = Common.Enums.SessionEnum.FirstVSPJ,
        TransportMode = Common.Enums.TransportModeEnum.Bus,
        Roommates = new string[] { "ahoj", "ahoj2" }
    };

    public static readonly RegistrationEntity AnotherRegistration = new()
    {
        Id = Guid.Parse("db68702a-764b-43b8-8b9b-af213d69d15b"),
        FirstName = "x",
        LastName = "x",
        EmailAddress = "x",
        PhoneNumber = "x",
        Department = Common.Enums.DepartmentEnum.EconomicStudiesVSPJ,
        BirthDate = DateTime.Parse("2/16/2008 12:15:12 PM"),
        Gender = Common.Enums.GenderEnum.Male,
        School = Common.Enums.SchoolEnum.VSPJ,
        Session = Common.Enums.SessionEnum.FirstVSPJ,
        TransportMode = Common.Enums.TransportModeEnum.Individual,
        Roommates = new string[] { "ahoj", "ahoj2" }
    };

    public static void Seed(this ModelBuilder modelBuilder) => 
        modelBuilder.Entity<RegistrationEntity>().HasData(ExampleRegistration);
}
